﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Drawers
{
    class IsoscaleTriangleDrawer : Drawer
    {
        public override meta.Shape Meta { get { return new meta.IsoscaleTriangle(); } }

        public override void draw(Point anchor, Point cursor)
        {
            throw new NotImplementedException();
        }
    }
}