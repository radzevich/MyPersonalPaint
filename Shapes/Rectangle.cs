using System;
using System.Windows.Controls;

namespace PaintWPF
{
    class Rectangle : Assymmetric
    {
        public Rectangle(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}
