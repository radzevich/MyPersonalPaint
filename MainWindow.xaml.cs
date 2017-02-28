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
using UserShapes;

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

            var canvas = new Canvas();
            canvas.Width = SystemParameters.WorkArea.Width;
            canvas.Height = SystemParameters.WorkArea.Height;

            var shapeList = new ShapeList();
            foreach (UserShapes.Shape shape in shapeList)
            {
                shape.draw();
            }

        }
    }
}
