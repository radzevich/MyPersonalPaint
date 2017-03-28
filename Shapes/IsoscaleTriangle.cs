using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System;

namespace PaintWPF.Shapes
{
    class IsoscaleTriangle : Shape
    {
        public override StylusPointCollection GetShapePointCollection(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));
            pointCollection.Add(new StylusPoint((cursor.X + anchor.X) / 2, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));

            return pointCollection;
        }

        public IsoscaleTriangle() : base () { }
    }
}
