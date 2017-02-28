using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    abstract class Polygon : Shape
    {
        //Here is a place for filling color propertie.

        public Polygon(Point anchor, Point cursor) : base(anchor, cursor) { }  
    }
}
