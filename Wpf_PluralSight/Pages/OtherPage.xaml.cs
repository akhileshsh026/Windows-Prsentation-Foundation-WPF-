﻿using System;
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

namespace Wpf_PluralSight.Pages
{
    /// <summary>
    /// Interaction logic for OtherPage.xaml
    /// </summary>
    public partial class OtherPage : Page
    {
        public OtherPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Well Done Bro","Testing Click Event", MessageBoxButton.OK);
        }
    }
}
