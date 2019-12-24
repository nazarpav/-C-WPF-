using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _09._12._2019
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("eng");
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(((RadioButton)sender).IsChecked==true)
            {
                Grid1.IsEnabled = false;
                Grid2.IsEnabled = false;
                Grid3.IsEnabled = false;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                Grid1.IsEnabled = true;
                Grid2.IsEnabled = true;
                Grid3.IsEnabled = true;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //MainW.Background = new SolidColorBrush(Color.FromRgb(0, 160, 0));
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ////MainW.Background = new SolidColorBrush(Color.FromRgb(130, 130, 130));
            //MainW.
        }
    }
}
