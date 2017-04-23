using System.Windows.Ink;
using System.Windows.Media;

namespace PaintWPF.Configuration
{
    class DrawerStyle
    {
        //Default settings. 
        private readonly Color defaultShapeColor = Colors.Black;
        private readonly Color defaultFrameColor = Colors.Black;
        private readonly double defaultShapeThickness = 2;
        private readonly double defaultFrameThickness = 1;
        private readonly bool defaultShapeHighlighter = false;
        private readonly bool defaultFrameHighlighter = true;

        //Shape properties.
        public Color Color { get; set; }
        public bool Highlighter { get; set; }
        //TODO public DashStyle strokeDash { get { return drawingAttributes.Color; } set { drawingAttributes.Color = value; } }
        public double Thickness { get; set; }

        //Constructors
        public DrawerStyle()
        {
            Color = defaultShapeColor;
            Thickness = defaultShapeThickness;
            Highlighter = defaultShapeHighlighter;
            //TODO add Dash.
        }

        public DrawerStyle(Color color, double thickness, bool highlighter)
        {
            this.Color = color;
            this.Thickness = thickness;
            this.Highlighter = highlighter;
            //TODO add Dash.
        }
    }
}
