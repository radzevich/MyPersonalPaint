using System.Windows;
using System.Windows.Input;
using PaintWPF.Shapes;
using System.Windows.Controls;
using PaintWPF.Drawers;
using PaintWPF.Meta;
using PaintWPF.Configuration;
using System.Windows.Ink;
using System.Windows.Media;



namespace PaintWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MetaData metaData { get; set; }
        private Drawer drawer { get; set; }
        private MainConfig config { get; set; }

        private bool shapeSelected { get; set; }
        private bool selection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            config = new MainConfig();

            config.configChanged += Config_ConfigChanged;
            drawingBox.Strokes.StrokesChanged += Strokes_StrokesChanged;

            config.StrokeColor = Colors.Red;
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
            checkShape(sender);
            drawingBox.EditingMode = InkCanvasEditingMode.Select;
            selection = true;
        }

        private void PenButton_Click(object sender, RoutedEventArgs e)
        {
            checkShape(sender);
            drawingBox.EditingMode = InkCanvasEditingMode.Ink;    
        }

        private void ChooseShapeButton_Click(object sender, RoutedEventArgs e)
        {
            checkShape(sender);
            drawingBox.EditingMode = InkCanvasEditingMode.None;
            //TODO вынести в отдельное окно
        }

        private void SetParamsButton_Click(object sender, RoutedEventArgs e)
        {
            checkShape(sender);
        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            checkShape(sender);
            drawingBox.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void drawingBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shapeSelected)
            {
                metaData = new MetaData();
                drawer = new Drawer(new Rectangle(), metaData);
                metaData.anchor = e.GetPosition(drawingBox);
            }
        }

        private void drawingBox_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (shapeSelected && (e.LeftButton == MouseButtonState.Pressed))
            {
                metaData.cursor = e.GetPosition(drawingBox);

                if (!metaData.firstDrawn)
                {
                    drawingBox.Strokes.RemoveAt(metaData.index);   
                }
                else
                {
                    metaData.firstDrawn = false;
                }
                drawingBox.Strokes.Add(drawer.draw());
                metaData.index = drawingBox.Strokes.Count - 1;
            }
        }

        private void drawingBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            if (shapeSelected)
            {
                metaData = null;
            }
            else if (selection)
            {
                try
                {
                    var strokes = drawingBox.GetSelectedStrokes();
                    var drawerStyle = new DrawerStyle(strokes[0].DrawingAttributes.Color, 
                                                      strokes[0].DrawingAttributes.Width, 
                                                      strokes[0].DrawingAttributes.IsHighlighter
                                                      );
                    config.activeDrawerStyle = drawerStyle;
                }
                catch { }     
            }
        }

        private void Strokes_StrokesChanged(object sender, StrokeCollectionChangedEventArgs e)
        {
            foreach (var stroke in e.Added)
            {
                stroke.DrawingAttributes.Color = config.activeDrawerStyle.Color;
                stroke.DrawingAttributes.Width = config.activeDrawerStyle.Thickness;
                stroke.DrawingAttributes.Height = config.activeDrawerStyle.Thickness;
                stroke.DrawingAttributes.IsHighlighter = config.activeDrawerStyle.Highlighter;
            }
        }

        private void Config_ConfigChanged(object sender, DrawerStyle e)
        {
            drawingBox.DefaultDrawingAttributes.Color = e.Color;
            drawingBox.DefaultDrawingAttributes.Width = e.Thickness;
            drawingBox.DefaultDrawingAttributes.Height = e.Thickness;
            drawingBox.DefaultDrawingAttributes.IsHighlighter = e.Highlighter;
        }


        private void checkShape(object sender)
        {
            if (sender != ChooseShapeButton)
            {
                shapeSelected = false;
            }
            else
            {
                shapeSelected = true;
            }

            if (sender != SelectButton)
            {
                selection = true;
            }
            else
            {
                selection = false;
            }
        }

    }
}