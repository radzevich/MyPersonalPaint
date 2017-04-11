using System.Windows;
using System.Windows.Input;
using PaintWPF.Shapes;
using System.Windows.Controls;
using PaintWPF.Drawers;
using PaintWPF.Meta;

namespace PaintWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MetaData metaData { get; set; }
        private Drawer drawer { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var config = new MainConfig();

            //drawingBox.EditingMode = InkCanvasEditingMode.Ink;

            //Call this code by event
            /*metaData = new MetaData(new Point(0, 0), new Point(200, 200));
            drawer = new Drawer(new Rectangle(), metaData);
            drawingBox.Strokes.Add(drawer.draw());

            metaData = new MetaData(new Point(0, 200), new Point(200, 200));
            drawer = new Drawer(new Line(), metaData);
            drawingBox.Strokes.Add(drawer.draw());

            metaData = new MetaData(new Point(200, 0), new Point(200, 200));
            drawer = new Drawer(new Line(), metaData);
            drawingBox.Strokes.Add(drawer.draw());



            */
            metaData = new MetaData(new Point(200, 200), new Point(300, 300));
            drawer = new Drawer(new IsoscaleTriangle(), metaData);
            drawingBox.Strokes.Add(drawer.drawWithFrame());
        }

        private void drawingBox_KeyDown(object sender, KeyEventArgs e)
        {
            //public static bool index;

            //var drawer = new Drawer(new Line(), metaData);
            //drawingBox.Strokes.Add(drawer.draw());
            //drawingBox.Strokes.RemoveAt(0);
            
            if (metaData.firstDrawn)
            {
                metaData.firstDrawn = false;
                drawingBox.Strokes.Add(drawer.draw());
            }
            else
            {
                drawingBox.Strokes.RemoveAt(metaData.index);
                drawingBox.Strokes.Add(drawer.draw());
            }
            metaData.index = drawingBox.Strokes.Count - 1;
            metaData.anchor = new Point(metaData.anchor.X + 1, metaData.anchor.Y + 1);
            metaData.cursor = new Point(metaData.cursor.X + 1, metaData.cursor.Y + 1);
        }

        public void Initiaalize()
        {
            InitializeComponent();

        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.Select;
        }

        private void PenButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void ChooseShapeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SetParamsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        //private void drawFrame
    }
}