using System;

namespace UserShapes
{
    abstract class Assymmetric : Polygon
    {
        public Assymmetric(Point anchor, Point cursor) : base(anchor, cursor) { }
    }
}
