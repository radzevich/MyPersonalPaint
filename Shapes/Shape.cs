using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;

namespace PaintWPF.Shapes
{
    abstract class Shape
    {
        public abstract StylusPointCollection GetShapePointCollection(Point anchor, Point cursor);

        public Shape() { }
    }
}
