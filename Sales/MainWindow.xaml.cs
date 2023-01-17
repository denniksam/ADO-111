using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data.SqlClient;   // Подключаем ADO для MS SQL Server (не забыть NuGet)

namespace Sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection _connection;  // объект-подключение к БД
        public MainWindow()
        {
            InitializeComponent();
            // строка подключения - берется из свойств БД (Server Explorer)
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\_dns_\source\repos\ADO-111\Sales\Sales111.mdf;Integrated Security=True";
            // создание объекта-подключения !! не открывает подключение
            _connection = new(connectionString);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                _connection.Open();  // открытие подключения
                MonitorConnection.Content = "Установлено";
                MonitorConnection.Foreground = Brushes.Green;
            }
            catch(SqlException ex)
            {
                MonitorConnection.Content = "Закрыто";
                MonitorConnection.Foreground = Brushes.Red;
                MessageBox.Show(ex.Message);
                this.Close();
            }
            ShowDepartmentsCount();
        }

        /// <summary>
        /// Выводит в таблицу-монитор количество отделов (департаментов) из БД
        /// </summary>
        private void ShowDepartmentsCount()
        {
            String sql = "SELECT COUNT(*) FROM Departments";
            // SqlCommand объект для передачи команд (запросов) к БД.
            // Требует закрытия, поэтому using
            using var cmd = new SqlCommand(sql, _connection);
            // создание объекта не исполняет команду, для этого есть методы ExecuteXxxx
            MonitorDepartments.Content =
                Convert.ToString(
                    cmd.ExecuteScalar()   // выполняет команду и возвращает "верхний-левый" результат
                );
        }
    }
}
