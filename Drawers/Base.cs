using System.Windows.Controls;

namespace PaintWPF
{
    //The base class for all geometric shapes.
    abstract class Shape
    {
        private Point anchor;
        private Point cursor;

        public Point Anchor
        {
            get { return anchor; }
            set
            {
                if (null == value)
                {
                    throw new System.ArgumentNullException();
                }
                anchor = value;
            }
        }

        public Point Cursor
        {
            get { return cursor; }
            set
            {
                if (null == value)
                {
                    throw new System.ArgumentNullException();
                }
                cursor = value;
            }
        }

        public Shape(Point anchor, Point cursor)
        {
            Anchor = anchor;
            Cursor = cursor;  
        }
    }
}
