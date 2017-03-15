using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintWPF;

namespace PaintWPF.Logic
{
    static class Drawer
    {
        delegate void delegateDraw(Shape shape);

        static void DrawLine(Shape shape) { }

        static void DrawRectangle(Shape shape) { }

        static void DrawSquare(Shape shape) { }

        static void DrawCircle(Shape shape) { }

        static void DrawEllipse(Shape shape) { }

        static void DrawRightTriangle(Shape shape) { }

        static void DrawIsoscalesTriangle(Shape shape) { }

        static void Draw(delegateDraw draw, Shape shape)
        {
            
        }
    }
}
