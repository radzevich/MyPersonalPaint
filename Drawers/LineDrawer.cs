﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Drawers
{
    class LineDrawer : Drawer
    {
        public override meta.Shape Meta { get { return new meta.Line(); } }

        public override void draw(Point anchor, Point cursor)
        {
            throw new NotImplementedException();
        }
    }
}