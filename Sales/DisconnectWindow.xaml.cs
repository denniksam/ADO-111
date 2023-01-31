using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DisconnectWindow.xaml
    /// </summary>
    public partial class DisconnectWindow : Window
    {
        public ObservableCollection<Entities.Department> Departments { get; set; }
        public DisconnectWindow()
        {
            InitializeComponent();
            // Связывание. Часть 1. Контекст
            DataContext = this;  // Представление получает доступ к всему объекту окна

        }
    }
}
