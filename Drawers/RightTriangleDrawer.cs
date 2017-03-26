using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System;

namespace PaintWPF.Drawers
{
    class RightTriangleDrawer : Drawer
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            throw new NotImplementedException();
        }

        public RightTriangleDrawer() : base () { }
    }
}
