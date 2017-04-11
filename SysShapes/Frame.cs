using System.Windows;
using System.Windows.Input;

namespace PaintWPF.SysShapes
{
    abstract class Frame
    {
        public abstract StylusPointCollection GetFramePointCollection(Point anchor, Point cursor);

        public Frame() { }
    }
}
