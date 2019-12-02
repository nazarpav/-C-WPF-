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
using System.Diagnostics;

namespace _02._12._2019
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(QuantityPassenger.Content.ToString()) > 0)
            {
                QuantityPassenger.Content = int.Parse(QuantityPassenger.Content.ToString()) - 1;
            }
        }

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            if(int.Parse(QuantityPassenger.Content.ToString())<8)
            {
                QuantityPassenger.Content = int.Parse(QuantityPassenger.Content.ToString()) + 1;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearAllData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(CheckBox.IsChecked !=null & CheckBox.IsChecked==true)
            {
                MessageBox.Show("Success");
                ClearAllData();
            }
        }
        private void ClearAllData()
        {
            MainWindow newWindow = new MainWindow();
            this.Close();
            newWindow.Show();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            ButtonGo.IsEnabled = CheckBox.IsChecked != null & CheckBox.IsChecked == true;
        }
    }
}
