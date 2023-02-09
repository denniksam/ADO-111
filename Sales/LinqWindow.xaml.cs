using System;
using System.Collections;
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
    /// Interaction logic for LinqWindow.xaml
    /// </summary>
    public partial class LinqWindow : Window
    {
        private LinqContext.DataContext context;
        public LinqWindow()
        {
            InitializeComponent();
            try
            {
                context = new(App.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Simple_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products.OrderBy(p => p.Price);
            textBlock1.Text = "";
            foreach(var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
        }

        private void ByName_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products.OrderBy(p => p.Name);
            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
        }

        private void ByPrice_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products.OrderByDescending(p => p.Price);
            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
        }

        private void Less200_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products
                        .Where(p => p.Price < 200)
                        .OrderBy(p => p.Price);
            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
        }

        private void withG_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products
                            .Where(p => p.Name.StartsWith("Г"));
            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
            textBlock1.Text += "\n" + query.Count() + " Total";
        }

        private void withOV_Click(object sender, RoutedEventArgs e)
        {
            var query = context.Products
                            .Where(p => p.Name.Contains("ов"));
            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Price + " " + item.Name + "\n";
            }
            textBlock1.Text += "\n" + query.Count() + " Total";
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            // LINQ объединения
            var query2 = from m in context.Managers
                        join d in context.Departments on m.IdMainDep equals d.Id
                        select new
                        {
                            Manager = m.Surname + " " + m.Name,
                            Department = d.Name
                        };

            var query = context.Managers.Join(  // метод объединения
                context.Departments,            // коллекция с которой объединяется
                m => m.IdMainDep,               // функция извлечения внешнего ключа
                d => d.Id,                      // -- первичного ключа
                (m, d) =>                       // функция композиции из двух объектов с совпавшими ключами
                    new { Manager = m.Surname + " " + m.Name, Department = d.Name });

            textBlock1.Text = "";
            foreach (var item in query)
            {
                textBlock1.Text += item.Manager + " - " + item.Department + "\n";
            }
            textBlock1.Text += "\n" + query.Count() + " Total";
        }
    }
}
/* Задания: используя LINQ запросы
 * Вывести товары по цене (сделано)
 * Вывести товары по названию
 * Вывести товары по убывающей цене
 * Вывести товары, которые дешевле 200 грн + сортировать по цене
 * По каждому из заданий вывести строку с итоговым кол-вом (Найдено ХХ позиций)
 * Вывести товары, название которых
 *   - начинается на "Г"
 *   - содержит "ов"
 * Вывести мененджеров с указанием отдела по совместительству
 * Вывести мененджеров с указанием руководителя
 * Вывести мененджеров с указанием и отдела и руководителя
 */