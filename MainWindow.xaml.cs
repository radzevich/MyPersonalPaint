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

namespace PaintWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var circle = new System.Windows.Shapes.Ellipse();
            drawingBox.Children.Add(circle);
            
        }

        private void Circle_Button_Click(object sender, RoutedEventArgs e)
        {
            Drawer
        }

        private void Line_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Right_Triangle_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Isoscale_Triangle_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rectangle_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Square_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ellipse_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
