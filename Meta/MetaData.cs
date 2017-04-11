using System.Windows;

namespace PaintWPF.Meta
{
    class MetaData
    {
        public virtual Point anchor { get; set; }
        public virtual Point cursor { get; set; }
        public bool firstDrawn { get; set; }
        public int index { get; set; }

        public MetaData ()
        {
            firstDrawn = true;
        }
        public MetaData (Point anchor)
        {
            firstDrawn = true;
            this.anchor = anchor;
        }
        public MetaData (Point anchor, Point cursor)
        {
            firstDrawn = true;
            this.anchor = anchor;
            this.cursor = cursor;
        }
    }
}
