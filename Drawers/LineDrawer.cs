using System.Windows.Input;
using System.Windows;
using System.Windows.Ink;
using System;

namespace PaintWPF.Drawers
{
    class LineDrawer : Drawer
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            throw new NotImplementedException();
        }

        public LineDrawer() : base () { }
    }
}
