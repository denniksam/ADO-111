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
    }
}
