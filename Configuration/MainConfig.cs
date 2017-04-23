using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintWPF.Shapes;
using PaintWPF.SysShapes;
using System.Windows.Media;
using System.Windows.Ink;


namespace PaintWPF.Configuration
{
    class MainConfig
    {
        //Contains primary settings (shape color, line thickness etc.).
        private readonly DrawerStyle primaryConfig;
        //Contains configuration of focused item.
        public DrawerStyle activeConfig { get; set; }
        //Contanes frame configuration.
        public DrawerStyle frameConfig { get; set; }

        //Shape pattern (rectangle by default).
        private Frame setedFrame = new RectangleFrame();

        //Shape configuration properties.
        public Color StrokeColor
        {
            get { return activeConfig.Color; }
            set { activeConfig.Color = value; }
        }

        public double StrokeThickness
        {
            get { return activeConfig.Thickness; }
            set { activeConfig.Thickness = value; }
        } 

        public bool StrokeHighliter
        {
            get { return activeConfig.Highlighter; }
            set { activeConfig.Highlighter = value; }
        }

        //Frame configuration properties.
        public Color FrameColor
        {
            get { return frameConfig.Color; }
            set { frameConfig.Color = value; }
        }

        public double FrameThickness
        {
            get { return frameConfig.Thickness; }
            set { frameConfig.Thickness = value; }
        }

        public bool FrameHighliter
        {
            get { return frameConfig.Highlighter; }
            set { frameConfig.Highlighter = value; }
        }

        private void backupConfig()
        {
            activeConfig = primaryConfig;
        }

        //Constructor.
        public MainConfig()
        {
            primaryConfig = new DrawerStyle();
            //frameConfig = new DrawingAttributes();
            activeConfig = primaryConfig;
        }
    }
}
