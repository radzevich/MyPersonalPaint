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
        private readonly StyleConfig mainConfig;
        //Frame configuration.
        public readonly StyleConfig frameConfig;
        //Contains configuration of focused shape.
        public StyleConfig shapeConfig { get; set; }
        

        public MainConfig()
        {
            mainConfig = new StyleConfig(defaultShapeColor, defaultShapeStrokeThikness, defaultShapeHighliner);
            frameConfig = new StyleConfig(defaultFrameColor, defaultFrameStrokeThikness, defaultFrameHighliner);
            shapeConfig = mainConfig;
        }


        private Shape setedShape = null;
        private Frame setedFrame = new RectangleFrame();

    }
}
