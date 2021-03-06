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

namespace _13._12._2019
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ButtonAdd.IsEnabled = true;
            ColorView.Background = new SolidColorBrush(Color.FromArgb(byte.Parse(AlphaC.Content.ToString()), byte.Parse(RedC.Content.ToString()), byte.Parse(GreenC.Content.ToString()), byte.Parse(BlueC.Content.ToString())));
            CheckAddButton();
        }
        private void CheckAddButton()
        {
            foreach (var i in ListBox_.Items)
            {
                if (((Label)((StackPanel)i).Children[0]).Content.ToString() == ColorView.Background.ToString())
                {
                    ButtonAdd.IsEnabled = false;
                    break;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox_.Items.Add(new StackPanel());
            ((StackPanel)ListBox_.Items[ListBox_.Items.Count - 1]).Orientation = Orientation.Horizontal;
            Label label = new Label();
            label.Content = ColorView.Background.ToString();
            label.BorderThickness = new Thickness(2);
            label.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            label.Height = 30;
            label.FontFamily = new FontFamily("Arial Black");
            label.FontSize = 16;
            Label label2 = new Label();
            ((StackPanel)ListBox_.Items[ListBox_.Items.Count - 1]).Children.Add(label);
            label2.BorderThickness = new Thickness(2);
            label2.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            label2.Height = 30;
            label2.Background = ColorView.Background;
            //Binding binding = new Binding();
            //binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            //binding.Source = AlphaC.ActualWidth;
            //label2.SetBinding(WidthProperty, binding);
            label2.Width = 604;
           ((StackPanel)ListBox_.Items[ListBox_.Items.Count - 1]).Children.Add(label2);
            Button button = new Button();
            button.Content = "X";
            button.FontFamily = new FontFamily("Arial Black");
            button.FontSize = 24;
            button.Click += ButtonDelete_Click;
            ((StackPanel)ListBox_.Items[ListBox_.Items.Count - 1]).Children.Add(button);
            UpdateButton();
            CheckAddButton();
        }
        private void UpdateButton()
        {
            int counter = 0;
            string n = String.Empty;
            foreach (var i in ListBox_.Items)
            {
                n = "_";
                n += counter++.ToString();
                ((Button)((StackPanel)i).Children[2]).Name = n;
            }
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            ListBox_.Items.Remove(ListBox_.Items[int.Parse(((Button)sender).Name.Remove(0, 1))]);
            UpdateButton();
        }
    }
}
