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
    /// Interaction logic for DataContext_Scope.xaml
    /// </summary>
    public partial class DataContext_Scope : Page
    {
        Person person = new Person();
        public DataContext_Scope()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = txtName.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}
