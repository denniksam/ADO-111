using Sales.Entities;
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
        public ObservableCollection<Entities.Manager> Managers { get; set; }
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

                #region Managers
                Managers = new();
                using SqlCommand cmd3 = new("SELECT Id, Surname, Name, Secname, Id_main_dep, Id_sec_dep, Id_chief FROM Managers", connection);
                {
                    using var reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        Managers.Add(new() 
                        {
                            Id = reader.GetGuid(0),
                            Surname = reader.GetString(1),
                            Name = reader.GetString(2),
                            Secname = reader.GetString(3),
                            IdMainDep = reader.GetGuid(4),
                            IdSecDep = reader[5] == DBNull.Value   // В БД любой элемент может быть NULL
                                        ? null                     // но в С# значимые типы не могут
                                        : reader.GetGuid(5),       // принимать null значение
                            IdChief = reader[6] == DBNull.Value    // Для передачи значимых типов, но опциональных
                                        ? null                     // сначала запрашивают object, его проверяют
                                        : reader.GetGuid(6)        // на DBNull.Value и если это не так, то
                        });                                        // повторяют запрос со значимым Get-тером (GetGuid)
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
                        using SqlConnection connection = new(App.ConnectionString);
                        try
                        {
                            connection.Open();
                            using SqlCommand cmd = new() { Connection = connection };
                            if (window.Department is null)  // удаление
                            {
                                cmd.CommandText = $"DELETE FROM Departments WHERE Id = '{department.Id}' ";
                            }
                            else  // изменение
                            {
                                cmd.CommandText = $"UPDATE Departments SET Name = @name WHERE Id = '{department.Id}' ";
                                cmd.Parameters.AddWithValue("@name", department.Name);
                                Departments.Insert(index, department);  // возвращаем, но измененный
                            }
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Задание выполнено успешно");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
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

        private void AddManager_Click(object sender, RoutedEventArgs e)
        {
            CRUD.CrudManagerWindow managerWindow = new() { Owner = this };
            managerWindow.ShowDialog();
        }

        private void ListViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var man = Managers[3];
            
            var dep1 = Departments.FirstOrDefault(d => d.Id == man.IdMainDep);
            var dep2 = Departments.FirstOrDefault(d => d.Id == man.IdSecDep);

            
            textBlock1.Text += man.Name + " " + dep1.Name + " " + 
                (dep2?.Name ?? "--") + "\n";
        }
    }
}
