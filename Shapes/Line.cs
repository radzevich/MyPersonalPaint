using System.Windows.Controls;

namespace PaintWPF
{
    sealed class Line : Shape
    {
        public Line(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw(Canvas canvas)
        {
            
        }
    }
}
