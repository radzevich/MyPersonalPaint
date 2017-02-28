using System;

namespace PaintWPF
{
    abstract class Assymmetric : Polygon
    {
        public Assymmetric(Point anchor, Point cursor) : base(anchor, cursor) { }
    }
}
