using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Drawers
{
    abstract class Drawer
    {
        public abstract void draw(Point anchor, Point cursor);
    }
}
