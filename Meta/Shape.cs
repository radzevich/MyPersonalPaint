using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintWPF.meta
{
    abstract class Shape
    {
        public virtual string IconImageName { get { return (GetType().ToString() + ".png"); } }
        public abstract bool RightShape { get; }

        /*public Shape(string iconImageName, bool rightShape)
        {
            if (iconImageName == null)
            {
                throw new ArgumentNullException();
            }
            this.iconImageName = iconImageName;
            this.rightShape = rightShape;
        }*/
    }
}
