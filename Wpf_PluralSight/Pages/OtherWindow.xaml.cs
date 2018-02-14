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

namespace Wpf_PluralSight.Pages
{
    /// <summary>
    /// Interaction logic for OtherWindow.xaml
    /// </summary>
    public partial class OtherWindow : Window
    {
        public OtherWindow()
        {
            InitializeComponent();
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("U amde it from Grid", "PrewiewMouseDown", MessageBoxButton.OK);
            
e.Handled = true;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("U amde it from Image", "MouseDown", MessageBoxButton.OK);
        }

        private void win_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U amde it from Button click event", "Click Event from button", MessageBoxButton.OK);
        }
    }
}
