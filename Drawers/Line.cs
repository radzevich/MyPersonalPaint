using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System;

namespace PaintWPF.Shapes
{
    class LineDrawer : Shape
    {
        public override Stroke getShapeStroke(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));

            var line = new Stroke(pointCollection);
            return line;
        }

        public LineDrawer() : base () { }
    }
}
