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
            get { return this.anchor; }
            set
            {
                if (null == value)
                {
                    throw new System.ArgumentNullException();
                }
                this.anchor = value;
            }
        }

        public Point Cursor
        {
            get { return this.cursor; }
            set
            {
                if (null == value)
                {
                    throw new System.ArgumentNullException();
                }
                this.cursor = value;
            }
        }

        public Shape(Point anchor, Point cursor)
        {
            try
            {
                Anchor = anchor;
                Cursor = cursor;  
            }
            catch
            {
                throw;
            }
        }

        abstract public void draw(Canvas canvas);
    }
}
