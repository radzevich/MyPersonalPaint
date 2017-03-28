using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace PaintWPF.Shapes
{
    abstract class Shape
    {
        public abstract Stroke getShapeStroke(Point anchor, Point cursor);

        public Shape() { }
    }
}
