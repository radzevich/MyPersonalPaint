using System.Windows;
using System.Windows.Input;
using PaintWPF.Shapes;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Controls;
using PaintWPF.Drawers;

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

            //Call this code by event
            //var drawer = new Drawer(new Line());
            //drawingBox.Strokes.Add(drawer.draw(new Point(100, 100), new Point(300, 300)));
        }
    }
}