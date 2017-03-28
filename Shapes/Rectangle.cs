using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;

namespace PaintWPF.Shapes
{
    class Rectangle : Shape
    {
        public override StylusPointCollection GetShapePointCollection(Point anchor, Point cursor)
        {
            
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));

            return pointCollection;                     
        }

        public Rectangle() : base () { }
    }
}
