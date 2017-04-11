using System.Windows;
using System.Windows.Input;

namespace PaintWPF.SysShapes
{
    class RectangleFrame : Frame
    {
        public override StylusPointCollection GetFramePointCollection(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();

            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, anchor.Y));
            pointCollection.Add(new StylusPoint(cursor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, cursor.Y));
            pointCollection.Add(new StylusPoint(anchor.X, anchor.Y));

            return pointCollection;
        }
    }
}
