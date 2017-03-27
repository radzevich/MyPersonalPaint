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
        private DrawingContext dc;

        public DrawingContext Dc
        {
            get { return this.dc; }
            set
            {
                dc = value;
                
            }
        }

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
            /*var circle = new Ellipse();
            var firstPoint = new Point(00, 100);
            circle.Width = 5;
            circle.Height = 5;
            circle.Stroke = Brushes.Black;
            circle.Width = 65;
            circle.Height = 70;*/
            //InkCanvas.SetTop(circle, firstPoint.Y);
            //InkCanvas.SetLeft(circle, firstPoint.X);
            //drawingBox.Strokes.Draw()

            this.InvalidateVisual();
            Pen myPen = new Pen(Brushes.Black, 3);
            if (dc != null)
            {
                dc.DrawLine(myPen, new Point(100, 100), new Point(500, 500));
                drawingBox.Strokes.Draw(dc);
            }
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);

            Pen myPen = new Pen(Brushes.Black, 3);
            dc.DrawLine(myPen, new Point(100, 100), new Point(500, 500));
            drawingBox.Strokes.Draw(dc);
        }
    }
}


