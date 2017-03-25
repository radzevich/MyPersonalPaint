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
            
            var line = new Line();                          //TODO replace absolute position
            line.X1 = 80;
            line.Y1 = 0;
            line.X2 = 500;
            line.Y2 = 100;
            line.Stroke = Brushes.LightSteelBlue;
            line.StrokeThickness = 2;
            drawingBox.Children.Add(line);

            //drawingBox.Children.Add(line);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var circle = new System.Windows.Shapes.Ellipse();
            
        }

        private void Circle_Button_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void drawingBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void drawingBox_PreviewDragOver(object sender, DragEventArgs e)
        {

        }
    }
}
