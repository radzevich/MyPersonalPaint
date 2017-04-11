using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintWPF.Shapes;
using PaintWPF.SysShapes;
using System.Windows.Media;
using System.Windows.Ink;


namespace PaintWPF.Meta
{
    class MainConfig
    {
        //Default values of drawing attributes. 
        private readonly Color defaultShapeColor = Colors.Black;
        private readonly Color defaultFrameColor = Colors.Black;
        private readonly double defaultShapeStrokeThikness = 2;
        private readonly double defaultFrameStrokeThikness = 1;
        private readonly bool defaultShapeHighliner = false;
        private readonly bool defaultFrameHighliner = true;


        //Contains global user settings (shape color, line thickness etc.).
        private readonly DrawingAttributes mainConfig;
        //Frame configuration.
        public readonly DrawingAttributes frameConfig;
        //Contains configuration of focused shape.
        public DrawingAttributes shapeConfig { get; set; }

        //Shape to draw.
        private Shape setedShape = null;
        //Shape pattern (rectangle by default).
        private Frame setedFrame = new RectangleFrame();

        //Shape configuration properties.
        public Color ShapeColor
        {
            get { return mainConfig.Color; }
            set { mainConfig.Color = value; }
        }

        public double ShapeThickness
        {
            get { return shapeConfig.Width; }
            set
            {
                shapeConfig.Width = value;
                shapeConfig.Height = value;
            }
        } 

        public bool ShapeHighliter
        {
            get { return shapeConfig.IsHighlighter; }
            set { shapeConfig.IsHighlighter = value; }
        }

        //Frame configuration properties.
        public Color FrameColor
        {
            get { return frameConfig.Color; }
            set { frameConfig.Color = value; }
        }

        public double FramThickness
        {
            get { return frameConfig.Width; }
            set
            {
                frameConfig.Width = value;
                frameConfig.Height = value;
            }
        }

        public bool FramHighliter
        {
            get { return frameConfig.IsHighlighter; }
            set { frameConfig.IsHighlighter = value; }
        }

        private void backupConfig()
        {
            shapeConfig = mainConfig;
        }

        //Constructor.
        public MainConfig()
        {
            mainConfig = new DrawingAttributes();
            mainConfig.Color = defaultShapeColor;
            mainConfig.Width = defaultShapeStrokeThikness;
            mainConfig.Height = defaultShapeStrokeThikness;
            mainConfig.IsHighlighter = defaultShapeHighliner;
            frameConfig = new DrawingAttributes();
            frameConfig.Color = defaultFrameColor;
            frameConfig.Width = defaultFrameStrokeThikness;
            frameConfig.Height = defaultFrameStrokeThikness;
            frameConfig.IsHighlighter = defaultFrameHighliner;
            shapeConfig = mainConfig;
        }
    }
}
