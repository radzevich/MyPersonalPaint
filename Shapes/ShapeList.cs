using System.Collections.Generic;

namespace UserShapes
{
    class ShapeList : List<Shape>
    {
        public ShapeList()
        {
            try
            {
                Add(new Ellipse(new Point(20, 20), new Point(100, 140)));
                Add(new Circle(new Point(150, 20), new Point(230, 140)));
                Add(new RightTriangle(new Point(20, 200), new Point(100, 320)));
                Add(new IsoscalesTriangle(new Point(150, 200), new Point(230, 320)));
                Add(new Rectangle(new Point(20, 380), new Point(100, 500)));
                Add(new Square(new Point(150, 380), new Point(230, 500)));               
            }
            catch
            {
                throw;
            }
        } 
    }
}
