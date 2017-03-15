using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.Logic
{
    static class Drawer
    {
        //Use frame's coords for drawing shape inside 
        private static Rectangle frame;

        public delegate void delegateDraw();
        public static delegateDraw draw;

        public static void DrawLine() { }

        public static void DrawRectangle() { }

        public static void DrawSquare() { }

        public static void DrawCircle() { }

        public static void DrawEllipse() { }

        public static void DrawRightTriangle() { }

        public static void DrawIsoscalesTriangle() { }

        public static void Draw()
        {
            DrawRectangle();            //drawing frame
            draw();                     //drawing shape inside the frame
        }
    }
}
