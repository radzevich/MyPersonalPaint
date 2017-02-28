using System;

namespace UserShapes
{
    sealed class Line : Shape
    {
        public Line(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }
    }
}
