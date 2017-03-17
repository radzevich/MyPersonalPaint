using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintWPF.meta;

namespace PaintWPF.Drawers
{
    abstract class Drawer
    {
        public abstract meta.Shape Meta { get; }
        public abstract void draw(Point anchor, Point cursor);
    }
}
