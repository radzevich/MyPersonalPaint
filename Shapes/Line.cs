using System.Windows.Controls;
using System.Windows.Shapes;

namespace PaintWPF
{
    sealed class Line : Shape
    {
        public Line(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw(Canvas canvas)
        {
            var line = new System.Windows.Shapes.Line();
            line.Width = 5;
            line.Stroke = System.Windows.SystemColors.WindowTextBrush;
            line.X1 = Anchor.X;
            line.Y1 = Anchor.Y;
            line.X2 = Cursor.X;
            line.Y2 = Cursor.Y;

            canvas.Children.Add(line);
        }
    }
}
