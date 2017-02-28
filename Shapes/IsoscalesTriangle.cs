using System;
using System.Windows.Controls;

namespace PaintWPF
{
    class IsoscalesTriangle : Symmetric
    {
        public IsoscalesTriangle(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}
