using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Drawers
{
    class Drawer
    {
        private readonly Meta.ShapeMeta Meta;

        public Drawer(Meta.ShapeMeta Meta)
        {
            this.Meta = Meta; 
        }

        protected Point Anchor { get { return Meta.Anchor; } }
        protected Point Cursor { get { return Meta.Cursor; } }
    }
}
