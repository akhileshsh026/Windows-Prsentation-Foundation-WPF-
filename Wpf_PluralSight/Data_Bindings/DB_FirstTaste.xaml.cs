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

namespace Wpf_PluralSight.Data_Bindings
{
    /// <summary>
    /// Interaction logic for DB_FirstTaste.xaml
    /// </summary>
    public partial class DB_FirstTaste : Page
    {

        Person person = new Person();
        public DB_FirstTaste()
        {
            InitializeComponent();
            txtName.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.Name);
        }
    }
}
