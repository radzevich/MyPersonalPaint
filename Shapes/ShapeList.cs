using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    class ShapeList
    {
        private List<Shape> shapeList;

        public ShapeList()
        {
            try
            {
                shapeList.Add(new Ellipse(new Point(20, 20), new Point(100, 140)));
                shapeList.Add(new Circle(new Point(150, 20), new Point(230, 140)));          
                shapeList.Add(new RightTriangle(new Point(20, 200), new Point(100, 320)));
                shapeList.Add(new IsoscalesTriangle(new Point(150, 200), new Point(230, 320)));            
                shapeList.Add(new Rectangle(new Point(20, 380), new Point(100, 500)));
                shapeList.Add(new Square(new Point(150, 380), new Point(230, 500)));               
            }
            catch
            {
                throw;
            }
        }
    }
}
