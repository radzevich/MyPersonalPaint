using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using System;

namespace PaintWPF.Drawers
{
    class EllipseDrawer : Drawer
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            var circle = new System.Windows.Shapes.Ellipse();
            //Stroke stroke = circle.StrokeEndLineCap;
            throw new NotImplementedException();
        }

        public EllipseDrawer() : base () { }
    }
}
