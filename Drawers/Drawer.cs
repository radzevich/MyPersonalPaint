using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintWPF.Shapes;
using System.Windows;
using System.Windows.Ink;

namespace PaintWPF.Drawers
{
    class Drawer
    {
        private readonly Shape shape;

        public virtual Stroke draw(Point anchor, Point cursor)
        {
            var stroke = new Stroke(shape.GetShapePointCollection(anchor, cursor));
            return stroke;
        }

        public Drawer(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException();
            }
            this.shape = shape;
        }
    }
}
