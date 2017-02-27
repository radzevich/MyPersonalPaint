using System;

namespace UserShapes
{
    class Point
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
    }
}
