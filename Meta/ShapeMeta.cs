namespace PaintWPF.Meta
{
    class ShapeMeta
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

        public ShapeMeta(Point anchor, Point cursor)
        {
            Anchor = anchor;
            Cursor = cursor;  
        }
    }
}
