using ContactList.Models;
using ContactList.ViewModels;
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

namespace WpfApp2.Views
{
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            ContactBookManager manager = new ContactBookManager();
            manager.LoadBook();

            viewModel = new MainWindowViewModel(manager);

            listBoxContact.ItemsSource = viewModel.observableBook;
            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContactViewModel newContact = new ContactViewModel()
            {
                Name = nameTxtBox.Text,
                Surname = surnameTxtBox.Text,
                Phone = phoneTxtBox.Text,
            };

            viewModel.Add(newContact);
        }

        private void ButtonClickEdit(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClickDelete(object sender, RoutedEventArgs e)
        {

        }
    }
}
