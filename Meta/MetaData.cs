using System.Windows;
using PaintWPF.Shapes;

namespace PaintWPF.Meta
{
    class MetaData
    {
        public Shape shape { get; private set; }
        public virtual Point anchor { get; set; }
        public virtual Point cursor { get; set; }
        public bool firstDrawn { get; set; }
        public int index { get; set; }

        public MetaData (Shape shape)
        {
            this.shape = shape;
            firstDrawn = true;
        }
        public MetaData (Shape shape, Point anchor)
        {
            this.shape = shape;
            this.anchor = anchor;
            firstDrawn = true;
        }
        public MetaData (Shape shape, Point anchor, Point cursor)
        {
            this.shape = shape;
            this.anchor = anchor;
            this.cursor = cursor;
            firstDrawn = true;
        }
    }
}
