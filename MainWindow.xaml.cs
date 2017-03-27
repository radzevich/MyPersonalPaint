using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;
using PaintWPF.Drawers;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Controls;

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

            var shapeDrawer = new RightTriangleDrawer();
            Stroke rect = shapeDrawer.draw(new Point(50, 500), new Point(200, 200));

            DrawingAttributes attribs = new DrawingAttributes();
            //attribs.Color = ;//Colors.LimeGreen;
            attribs.Height = 5.0;
            attribs.Width = 5.0;
            attribs.FitToCurve = false;
            //drawingBox.IsEnabled = false;

            rect.DrawingAttributes = attribs;

                drawingBox.Strokes.Add(rect);

            //drawingBox.Strokes.Clear();
            var circle = new Ellipse();
            var firstPoint = new Point(00, 100);
            circle.Width = 5;
            circle.Height = 5;
            circle.Stroke = Brushes.Black;
            circle.Width = 65;
            circle.Height = 70;
            //InkCanvas.SetTop(circle, firstPoint.Y);
            //InkCanvas.SetLeft(circle, firstPoint.X);
            drawingBox.Strokes.Draw()
        }

        protected override void OnRender(DrawingContext dc)
        {

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            
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

        private void drawingBox_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.IsEnabled = !this.IsEnabled;
        }

        private void drawingBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.IsEnabled = !this.IsEnabled;

            var myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = 80;
            myLine.X2 = 500;
            myLine.Y1 = 10;
            myLine.Y2 = 500;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;

            AddVisualChild(myLine);
            IsEnabled = !IsEnabled;

        }
    }
}
