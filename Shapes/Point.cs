using System;

namespace PaintWPF
{
    sealed class Point
    {
        private int x;
        private int y;
        
        public int X
        {
            get { return this.x; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.x = value;
            }                 
        }

        public int Y
        {
            get { return this.y; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.y = value;
            }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool isNullPoint()
        {
            return ((x == 0) & (y == 0));
        }

        public double distanceTo(Point point)
        {
            long xDistance = point.X - x;
            long yDistance = point.Y - y;
            return (Math.Sqrt (Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2)));
        }
    }
}
