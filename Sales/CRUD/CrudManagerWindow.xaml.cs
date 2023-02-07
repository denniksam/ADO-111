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

namespace Sales.CRUD
{
    /// <summary>
    /// Interaction logic for CrudManagerWindow.xaml
    /// </summary>
    public partial class CrudManagerWindow : Window
    {
        public CrudManagerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = (Owner as DisconnectWindow);
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (DepartmentsCombo.SelectedValue is Entities.Department department)
            {
                Guid id = department.Id;
                MessageBox.Show(
                    $"{ManagerSurname.Text} - {ManagerName.Text} - {ManagerSecname.Text} - {id}"
                );
            }
            else
            {
                MessageBox.Show("Выберите отдел");
            }
            
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
/* Завершить разработку окна CrudManagerWindow
 * - организовать свойство Manager
 * - реализовать его начальную проверку на null (признак создания)
 *    в таком случае генерировать новый идентификатор
 * - иначе (не null) перенести данные из полей Manager в интерфейс
 * - по нажатию кнопки "сохранить" обеспечить проверку необходимых данных
 *    (на пустоту), в случае ошибки выдать предупреждение
 * ** рядом с комбобоксами "совместитель" и "шеф" добавить кнопки "сбросить"   
 */