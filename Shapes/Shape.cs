namespace UserShapes
{
    //The base class for all geometric shapes.
    abstract class Shape
    {
        private Point anchorPoint;

        public Point AnchorPoint
        {
            get { return this.anchorPoint; }
            set
            {
                if (null == value)
                {
                    throw new System.ArgumentNullException();
                }
                this.anchorPoint = value;
            }
        }

        public Shape()
        {
            try
            {
                AnchorPoint = new Point(0, 0);
            }
            catch
            {
                throw;
            }
        }

        public Shape(Point point)
        {
            try
            {
                AnchorPoint = point;
            }
            catch
            {
                throw;
            }
        }

        abstract public void draw();
    }
}
