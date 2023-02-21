using Microsoft.EntityFrameworkCore;
using Sales.EfContext;
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
using System.Windows.Shapes;

namespace Sales
{
    /// <summary>
    /// Interaction logic for EfWindow.xaml
    /// </summary>
    public partial class EfWindow : Window
    {
        public EfContext.DataContext dataContext;
        public EfWindow()
        {
            InitializeComponent();
            dataContext = new();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MonitorDepartments.Content =
                dataContext.Departments.Count();
            MonitorSales.Content = 
                dataContext.Sales.Count();

            ShowDailyStatistics();
            NavProperties();
        }

        private void ShowDailyStatistics()
        {
            // Статистика за сегодняшний день:
            // всего чеков (продаж)
            SalesCnt.Content = dataContext.Sales
                .Where(sale => sale.Moment.Date == DateTime.Now.Date).Count();

            // продано товаров (шт)
            SalesTotal.Content = dataContext.Sales
                .Where(sale => sale.Moment.Date == DateTime.Now.Date)
                .Sum(sale => sale.Cnt);

            // сумма продаж (грн)
            SalesMoney.Content = dataContext.Sales
                .Where(sale => sale.Moment.Date == DateTime.Now.Date)
                .Join(dataContext.Products,
                        sale => sale.ProductId,
                        prod => prod.Id,
                        (sale, prod) => sale.Cnt * prod.Price)
                .Sum()
                .ToString("0.00");

            // Лучший по продажам сотрудник
            SalesTopManager.Content = dataContext.Managers
                .GroupJoin(
                    dataContext.Sales.Where(sale => sale.Moment.Date == DateTime.Now.Date),
                    man => man.Id,
                    sale => sale.ManagerId,
                    (man, sales) => new {
                        Manager = man,
                        Total = sales
                                // .Sum(s => s.Cnt) 
                                .Join(dataContext.Products,
                                        sale => sale.ProductId,
                                        prod => prod.Id,
                                        (sale, prod) => sale.Cnt * prod.Price)
                                .Sum()
                    })
                .OrderByDescending(mix => mix.Total)
                .Take(1)   // Оставляет только 1 элемент - на развитие - если надо несколько лучших
                .Select(mix => mix.Manager.ToShortString() + $"({mix.Total})")
                .First();

            // Лучший по продажам товар
            SalesTopProduct.Content = dataContext.Products
                .GroupJoin(
                    dataContext.Sales.Where(s => s.Moment.Date == DateTime.Now.Date),
                    p => p.Id,
                    s => s.ProductId,
                    (p, ss) => new { Product = p, Total = p.Price * ss.Sum(s => s.Cnt) })
                .OrderByDescending(mix => mix.Total)
                .Take(1)
                .Select(mix => mix.Product.ToShortString() + $"({mix.Total}")
                .First();

            // Лучший по продажам отдел
            /*
            SalesTopDepartment.Content = dataContext.Departments
                .GroupJoin(
                    dataContext.Managers
                        .GroupJoin( 
                            dataContext.Sales.Where(s => s.Moment.Date == DateTime.Now.Date),
                            man => man.Id,
                            sale => sale.ManagerId,
                            (man, sales) => new { Manager = man, Total = sales.ToList().Sum(sale => sale.Cnt) }
                        ),
                    dep => dep.Id,
                    mix => mix.Manager.IdMainDep,
                    (dep, mixes) => new { Department = dep, Total = mixes.ToList().Sum(mix => mix.Total)}
                )
                .OrderByDescending(mixd => mixd.Total)
                .Select(mixd => mixd.Department.Name + $"({mixd.Total})")
                .First(); */

            SalesTopDepartment.Content = dataContext.Departments
                .Join(dataContext.Managers, d => d.Id, m => m.IdMainDep, (d, m) => new {Dep=d, Man=m})
                .GroupJoin(
                    dataContext.Sales.Where(s => s.Moment.Date == DateTime.Now.Date),
                    dm=>dm.Man.Id,
                    sale => sale.ManagerId,
                    (dm, sales) => new { Dep = dm.Dep, Man = dm.Man, Total = sales.Sum(sale=>sale.Cnt) }
                ).ToList()
                .GroupBy(
                    dms => dms.Dep,
                    dms=>dms.Total,
                    (dep,ts) => new {Dep = dep, Total = ts.Sum()}
                )
                .OrderByDescending(dt => dt.Total)
                .Select(dt => dt.Dep.Name + $"({dt.Total})")
                .First();


        }

        private void AddSalesButton_Click(object sender, RoutedEventArgs e)
        {
            int managersCount = dataContext.Managers.Count();
            int productsCount = dataContext.Products.Count();

            for (int i = 0; i < 100; i++)
            {
                dataContext.Sales.Add(new()
                {
                    Id = Guid.NewGuid(),
                    ManagerId = dataContext.Managers
                                .Skip(App.random.Next(managersCount))
                                .First()
                                .Id,
                    ProductId = dataContext.Products
                                .Skip(App.random.Next(productsCount))
                                .First()
                                .Id,
                    Cnt = App.random.Next(1, 10),
                    Moment = DateTime.Now + TimeSpan.FromHours(App.random.Next(-24,24))
                });
            }

            dataContext.SaveChanges();

            MonitorSales.Content = dataContext.Sales.Count();
            ShowDailyStatistics();
        }

        private void NavProperties()
        {
            var man = dataContext.Managers
                .Include(m => m.MainDep)
                .Include(m => m.Chief)
                .Include(m => m.Subordinates)
                .Skip(1)
                .First();

            label1.Content = man.Surname + " " + man.MainDep.Name + " " + man.SecDep.Name;

            var dep = dataContext.Departments.Include(d => d.Managers).Skip(1).First();
            label1.Content += "\n" + dep.Name 
                + "  " + dep.Managers.Count() + " mans"
                + ", " + dep.PartWorkers.Count() + " parts";

            label1.Content += "\n" 
                + (man.Chief?.Surname ?? "--") + " " 
                + man.Subordinates.Count() + " subs";
        }
    }
}
/* Вывести "таблицы" 
 *  - Название отдела - кол-во основных сотрудников - кол-во совместителей
 *  - ФИО сотрудника - ФИО начальника/--  - кол-во подчиненных
 *  - ФИО сотрудника - Основной отдел - отдел по совместительству/--
 */