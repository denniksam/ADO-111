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
using System.IO;
using System.Data;

namespace Sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection _connection;  // объект-подключение к БД
        private List<Entities.Department>? _departments;  // ORM: коллекция объектов-сущностей == таблица

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
            ShowManagersCount();
            ShowProductsCount();
            ShowSalesCount();

            ShowDailyStatistics();
            ShowDepartments();
        }

        #region Show Monitor

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

        /// <summary>
        /// Выводит в таблицу-монитор количество Товаров из БД
        /// </summary>
        private void ShowProductsCount()
        {
            String sql = "SELECT COUNT(*) FROM Products";
            using var cmd = new SqlCommand(sql, _connection);
            MonitorProducts.Content = Convert.ToString( cmd.ExecuteScalar() );
        }

        /// <summary>
        /// Выводит в таблицу-монитор количество Сотрудников (Менеджеров) из БД
        /// </summary>
        private void ShowManagersCount()
        {
            using SqlCommand cmd = new("SELECT COUNT(*) FROM Managers", _connection);
            MonitorManagers.Content = Convert.ToString(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Выводит в таблицу-монитор количество Продаж (чеков) из БД
        /// </summary>
        private void ShowSalesCount()
        {
            using SqlCommand cmd = new("SELECT COUNT(*) FROM Sales", _connection);
            MonitorSales.Content = Convert.ToString(cmd.ExecuteScalar());
        }
        #endregion


        /// <summary>
        /// Заполняет блок "Статистика за день"
        /// </summary>
        private void ShowDailyStatistics()
        {
            SqlCommand cmd = new()
            {
                Connection = _connection
            };
            // В БД информация за 2022 год, поэтому формируем дату с текущим днем и месяцем, но за 2022 год
            String date = $"2022-{DateTime.Now.Month}-{DateTime.Now.Day}";
            
            // Всего продаж (чеков)
            cmd.CommandText = $"SELECT COUNT(*) FROM Sales S WHERE CAST( S.Moment AS DATE ) = '{date}'";
            StatTotalSales.Content = Convert.ToString(cmd.ExecuteScalar());

            // Всего продаж (товаров, штук)
            cmd.CommandText = $"SELECT SUM(S.Cnt) FROM Sales S WHERE CAST( S.Moment AS DATE ) = '{date}'";
            StatTotalProducts.Content = Convert.ToString(cmd.ExecuteScalar());

            // Всего продаж (грн, деньги)
            cmd.CommandText = $"SELECT ROUND( SUM( S.Cnt * P.Price ), 2 ) FROM Sales S JOIN Products P ON S.Id_product = P.Id WHERE CAST( S.Moment AS DATE ) = '{date}'";
            StatTotalMoney.Content = Convert.ToString(cmd.ExecuteScalar());
            // File.ReadAllText("")

            cmd.Dispose();
        }

        /// <summary>
        /// Заполняет блок "Отделы" - выборка всех данных из таблицы Departments
        /// </summary>
        private void ShowDepartments()
        {
            using SqlCommand cmd = new("SELECT * FROM Departments", _connection);
            SqlDataReader reader = cmd.ExecuteReader();      // Табличный запрос - возвращает SqlDataReader
            DepartmentCell.Text = "";                        // Передача данных происходит "построчно" - по одной строке выборки (результата)
            while (reader.Read())                            // Вызов ExecuteReader не читает данные, только создает reader
            {                                                // Команда reader.Read() заполняет reader
                Guid id = reader.GetGuid("id");              // данными (строкой-выборкой) - "самозаполняется"
                String name = (String) reader[1];            // !! возврат Read() - статус (успех/конец)
                // double price = (double) reader["Price"];  // После чтения данные доступны
                DepartmentCell.Text += $"{id} {name} \n";    // а) через Get-теры (GetGuid/GetString,...) с индексом
            }                                                // б) через Get-теры с именем поля (using System.Data)
                                                             // в) через индексатор [] c числом - индексом поля
                                                             // г) через индексатор [] со строкой - названием поля
            // Значение индекса начинается с 0 и соответствует
            // порядку данных в строке-результате (в таблице)
            // Поскольку обращение к данным идет по индексам, крайне НЕ рекомендуется
            // оформлять запрос как SELECT * - в нем не видно порядок полей
            // Лучше перечислять поля SELECT id, name FROM Departments
            // reader обязательно нужно закрывать, если останется открытым, то не будут
            // выполняться другие команды
            reader.Dispose();
        }

    }
}
/* Д.З. Дополнить блок "Статистика за день" данными следующих категорий:
 * Самый эффективный менеджер [Фамилия, Имя] (по деньгам)
 * Самый эффективный отдел [Название] (по кол-ву проданных товаров)
 * Самый популярный товар [Название] (по кол-ву чеков)
 */