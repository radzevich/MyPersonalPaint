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

        private bool shapeSeted { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            config = new MainConfig();

            config.configChanged += Config_ConfigChanged;
            config.configBackup += Config_Backup;
            drawingBox.Strokes.StrokesChanged += Strokes_StrokesChanged;
        }


        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.Select;
        }

        private void PenButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.Ink;    
        }

        private void SetParamsButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.None;
        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            drawingBox.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

//*****************************************Drawing cycle****************************************
  
        private void drawingBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shapeSeted)
            {
                try
                {
                    drawer = new Drawer(metaData);
                    metaData.anchor = e.GetPosition(drawingBox);
                    metaData.firstDrawn = true;
                }
                catch { }
            }
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (shapeSeted && (e.LeftButton == MouseButtonState.Pressed))
            {
                try
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
                catch { }
            }
        }

        private void drawingBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            drawer = null;
      
            if (drawingBox.EditingMode == InkCanvasEditingMode.Select)
            {
                var strokes = drawingBox.GetSelectedStrokes();
                if (strokes.Count != 0)
                {
                    var drawerStyle = new DrawerStyle(strokes[0].DrawingAttributes.Color,
                                                      strokes[0].DrawingAttributes.Width,
                                                      strokes[0].DrawingAttributes.IsHighlighter
                                                      );
                    config.activeDrawerStyle = drawerStyle;
                }
            }
        }

//****************************************************************************************************
//************************************Drawer style configuration**************************************

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

            foreach (Stroke stroke in drawingBox.GetSelectedStrokes())
            {
                stroke.DrawingAttributes.Color = e.Color;
                stroke.DrawingAttributes.Width = e.Thickness;
                stroke.DrawingAttributes.Height = e.Thickness;
                stroke.DrawingAttributes.IsHighlighter = e.Highlighter;
            }
            SetedColorField.Background = new SolidColorBrush(e.Color);
        }

        private void Config_Backup(object sender, DrawerStyle e)
        {
            drawingBox.DefaultDrawingAttributes.Color = e.Color;
            drawingBox.DefaultDrawingAttributes.Width = e.Thickness;
            drawingBox.DefaultDrawingAttributes.Height = e.Thickness;
            drawingBox.DefaultDrawingAttributes.IsHighlighter = e.Highlighter;
            SetedColorField.Background = new SolidColorBrush(e.Color);
        }

//*******************************************************************************************************

//***************************OnButtonClickEvents*********************************************************
        private void LineSelectButton_Click(object sender, RoutedEventArgs e)
        {
            metaData = new MetaData(new Line());
        }

        private void TriangleSelectButton_Click(object sender, RoutedEventArgs e)
        {
            metaData = new MetaData(new IsoscaleTriangle());
        }

        private void RectanglectButton_Click(object sender, RoutedEventArgs e)
        {
            metaData = new MetaData(new Rectangle());
        }

        private void PentagonctButton_Click(object sender, RoutedEventArgs e)
        {
            metaData = new MetaData(new Pentagon());
        }

        private void StarSelectButton_Click(object sender, RoutedEventArgs e)
        {
            metaData = new MetaData(new Star());
        }

        private void Tools_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((shapeSeted) && (!ShapesField.IsStylusOver))
            {
                shapeSeted = false;
            }
        }

        private void ShapesField_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            shapeSeted = true;
            drawingBox.EditingMode = InkCanvasEditingMode.None;
        }

        private void SetBlackColor_Click(object sender, RoutedEventArgs e)
        {
            config.StrokeColor = ((sender as Button).Background as SolidColorBrush).Color;
        }

        private void drawingBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (drawingBox.EditingMode == InkCanvasEditingMode.Select)
            {
                config.backupConfig();
            }
        }
    }
}