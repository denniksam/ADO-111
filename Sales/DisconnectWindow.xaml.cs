using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sales
{
    /// <summary>
    /// Interaction logic for DisconnectWindow.xaml
    /// </summary>
    public partial class DisconnectWindow : Window
    {
        public ObservableCollection<Entities.Department> Departments { get; set; }
        public ObservableCollection<Entities.Product> Products { get; set; }
        public DisconnectWindow()
        {
            InitializeComponent();
            // Связывание. Часть 1. Контекст
            DataContext = this;  // Представление получает доступ к всему объекту окна
            using SqlConnection connection = new(App.ConnectionString);
            try
            {
                connection.Open();

                #region Departments
                Departments = new();
                using SqlCommand cmd = new("SELECT Id, Name FROM Departments", connection);
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Departments.Add(new()  // Изменение коллекции отобразиться на ListView
                        {
                            Id = reader.GetGuid(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                #endregion

                #region Products
                Products = new();
                using SqlCommand cmd2 = new("SELECT Id, Name, Price FROM Products", connection);
                {
                    using var reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        Products.Add(new()  // Изменение коллекции отобразиться на ListView
                        {
                            Id = reader.GetGuid(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDouble(2)
                        });
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(sender is ListViewItem item)  // item = sender as ListViewItem
            {
                // Обратная связь (view->model) через item.Content
                if (item.Content is Entities.Department department)
                {
                    // MessageBox.Show(department.ToShortString());
                    CRUD.CrudDepartmentWindow window = new()
                    {
                        Department = department
                    };
                    int index = Departments.IndexOf(department);
                    Departments.Remove(department);  // удаляем из коллекции и передаем на редактирование
                    if (window.ShowDialog().GetValueOrDefault())
                    {
                        if(window.Department is null)  // удаление
                        {
                            /* Написать команды для БД удаляющие и изменяющие
                             * отделы (Departments).
                             * Реализовать вызов этих команд по соответствующим
                             * ситуациям в программе
                             * Перед фактом удаление добавить диалог-подтверждение
                             */
                        }
                        else  // изменение
                        {
                            Departments.Insert(index, department);  // возвращаем, но измененный
                        }
                    }
                    else  // Отмена - возвращаем в окно
                    {
                        Departments.Insert(index, department);
                    }
                }
            }
            
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListViewItem item)  // item = sender as ListViewItem
            {
                // Обратная связь (view->model) через item.Content
                if (item.Content is Entities.Product product)
                {
                    MessageBox.Show(product.ToShortString());
                }
            }
        }

        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            var window = new CRUD.CrudDepartmentWindow();

            if(window.ShowDialog().GetValueOrDefault())
            {
                MessageBox.Show(window.Department.ToShortString());
                using SqlConnection connection = new(App.ConnectionString);
                try
                {
                    connection.Open();
                    using SqlCommand cmd = new(
                        $"INSERT INTO Departments(Id, Name) VALUES( @id, @name )", 
                        connection);
                    cmd.Parameters.AddWithValue("@id", window.Department.Id);
                    cmd.Parameters.AddWithValue("@name", window.Department.Name);
                    cmd.ExecuteNonQuery();

                    Departments.Add(window.Department);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
