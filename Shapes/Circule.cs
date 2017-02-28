using System;

namespace UserShapes
{
    class Circle : Symmetric
    {
        public Circle(Point anchor, Point cursor) : base (anchor, cursor) { }
      
        public override void draw()
        {
            throw new NotImplementedException();
        }
    }
}