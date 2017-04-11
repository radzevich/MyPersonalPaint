using System.Windows.Ink;
using System.Windows.Media;

namespace PaintWPF.Meta
{
    class StyleConfig
    {
        //Default settings. 
        readonly private Color defaultColor = Colors.Black;
        readonly private double defaultThickness = 2;
        readonly private bool defaultHighliter = false;
        readonly private DashStyle defaultDash = DashStyles.Solid;

        //Properties
        public DrawingAttributes drawingAttributes { get; set; }
        public Color strokeColor { get { return drawingAttributes.Color; } set { drawingAttributes.Color = value; } }
        public bool strokeHighliter { get { return drawingAttributes.IsHighlighter; } set { drawingAttributes.IsHighlighter = value; } }
        //TODO public DashStyle strokeDash { get { return drawingAttributes.Color; } set { drawingAttributes.Color = value; } }
        public double strokeThickness
        {
            get { return drawingAttributes.Width; }
            set
            {
                drawingAttributes.Width = value;
                drawingAttributes.Height = value;
            }
        }

        //Constructors
        public StyleConfig()
        {
            drawingAttributes = new DrawingAttributes();
            drawingAttributes.Color = defaultColor;
            strokeThickness = defaultThickness;
            drawingAttributes.IsHighlighter = defaultHighliter;
            //TODO add Dash.
        }

        public StyleConfig(Color color, double thickness, bool highliter)
        {
            drawingAttributes = new DrawingAttributes();
            strokeColor = color;
            strokeThickness = thickness;
            strokeHighliter = highliter;
            //TODO add Dash.
        }

        public StyleConfig(DrawingAttributes drawingAttributes)
        {
            this.drawingAttributes = drawingAttributes;
        }
    }
}
