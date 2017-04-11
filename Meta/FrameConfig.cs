using System.Windows.Media;
using System.Windows.Controls;
using System;
using PaintWPF.SysShapes;

namespace PaintWPF.Meta
{
    class FrameConfig
    {
        readonly Color defaultPenColor = Colors.Black;
        readonly double defaultThickness = 1;
        private System.Windows.Frame defaultFrame = null;
        public DashStyle dash = DashStyles.DashDot;
      

        public Color DefaultPenColor
        {
            get { return this.defaultPenColor; }    
        }

        public double DefaultThickness
        {
            get { return this.defaultThickness; }
        }
        public virtual float[] dashValue { get; set; }
    }


}
