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

namespace PaintMy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Figures SelectedFigure = Figures.Rectangle;
        private Point SavePoint;
        public MainWindow()
        {
            InitializeComponent();
            SavePoint = new Point(0,0);
        }

        private void ButtonCurveLine_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectedFigure = Figures.CurveLine;
        }
        private void ButtonLine_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectedFigure = Figures.Line;
        }
        private void ButtonCircle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectedFigure = Figures.Elipse;
        }
        private void ButtonRect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectedFigure = Figures.Rectangle;
        }

        private void Canvas__MouseDown(object sender, MouseButtonEventArgs e)
        {
            SavePoint = e.GetPosition((Canvas)sender);
        }
    }
}
