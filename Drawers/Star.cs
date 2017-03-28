using System;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;


namespace PaintWPF.Shapes
{
    class StarDrawer : Shape
    {
        public override Stroke draw(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();
            int rayNum = 5;                                                                                      //The number of rays in the star.
            double outsideRadius = Math.Min(Math.Abs(anchor.X - cursor.X), Math.Abs(anchor.Y - cursor.Y)) / 2;   //Getting radii of inscribed and circumscribed circles.
            double insideRadius = outsideRadius / 2;
            double angle = 20;                                                                                   //Pitch angle.
            double x = (anchor.X + cursor.X) / 2;                                                                //Center coords
            double y = (anchor.Y + cursor.Y) / 2;
            double div = x / y;

            //Counting of star's apexes coords.
            for (int i = 0; i < rayNum * 2; i++)
            {
                var point = new StylusPoint();
                //For odd apexes.
                if (i % 2 != 0) 
                {
                    point.X = x + insideRadius / 2 * Math.Cos(angle * Math.PI / 180) * div;
                    point.Y = y - insideRadius / 2 * Math.Sin(angle * Math.PI / 180) / div; 
                }
                //For even apexes.
                else 
                {
                    point.X = x + outsideRadius * Math.Cos(angle * Math.PI / 180) * div;
                    point.Y = y - outsideRadius * Math.Sin(angle * Math.PI / 180) / div;
                }
                angle = angle + 180 / rayNum;
                //Adding current apex to collection.
                pointCollection.Add(point);
            }

            //Adding first point to the collection's tail.
            pointCollection.Add(pointCollection[0]);

            //Drawing strokes between points.
            var star = new Stroke(pointCollection);
            return star;
        }

        public StarDrawer() : base () { }
    }
}
