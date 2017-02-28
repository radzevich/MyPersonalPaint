using System;

namespace UserShapes
{
    class Square : Symmetric
    {
        public Square(Point anchor, Point cursor) : base(anchor, cursor) { }

        public override void draw()
        {
            throw new NotImplementedException();
        }  
    }
}
