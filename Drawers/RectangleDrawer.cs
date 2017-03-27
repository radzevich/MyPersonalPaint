using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;

namespace PaintWPF.Drawers
{
    class RectangleDrawer : Drawer
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));

            var rectangle = new Stroke(pointCollection);
            
            return rectangle;                      
        }

        public RectangleDrawer() : base () { }
    }
}
