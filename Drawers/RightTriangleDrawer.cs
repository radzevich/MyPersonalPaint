using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Drawers
{
    class RightTriangleDrawer : Drawer
    {
        public override meta.Shape Meta { get { return new meta.RightTriangle(); } }

        public override void draw(Point anchor, Point cursor)
        {
            throw new NotImplementedException();
        }
    }
}
