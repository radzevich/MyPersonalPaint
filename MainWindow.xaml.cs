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

            var drawer = new StarDrawer();
            var stroke = drawer.draw(new Point(100, 100), new Point(200, 200));
            drawingBox.Strokes.Add(stroke);
        }
    }
}