using System.Windows.Controls;
using System;

namespace PaintWPF
{
    class Circle : Symmetric
    {
        public Circle(Point anchor, Point cursor) : base (anchor, cursor) { }
      
        public override void draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}