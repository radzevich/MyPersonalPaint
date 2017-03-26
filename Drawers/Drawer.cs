using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace PaintWPF.Drawers
{
    abstract class Drawer
    {
        public abstract Stroke draw(Point anchor, Point cursor);

        public Drawer() { }
    }
}
