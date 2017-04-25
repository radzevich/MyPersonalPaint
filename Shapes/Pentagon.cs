using System;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;

namespace PaintWPF.Shapes
{
    class Pentagon : Shape
    {
        public override StylusPointCollection GetShapePointCollection(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();
            int angleNum = 5;                                                                                    //The number of angles in the shape.
            double radius = Math.Min(Math.Abs(anchor.X - cursor.X), Math.Abs(anchor.Y - cursor.Y)) / 2;          //Getting radii of inscribed and circumscribed circles.
            double angle = 20;                                                                                   //Pitch angle.
            double x = (anchor.X + cursor.X) / 2;                                                                //Center coords
            double y = (anchor.Y + cursor.Y) / 2;
            double div = x / y;

            //Counting of star's apexes coords.
            for (int i = 1; i < angleNum * 2 + 2; i++)
            {
                var point = new StylusPoint();

                point.X = x + radius / 2 * Math.Cos(angle * Math.PI / 180) * div;
                point.Y = y - radius / 2 * Math.Sin(angle * Math.PI / 180) / div;

                angle = angle + 360 / angleNum;
                //Adding current apex to collection.
                pointCollection.Add(point);
            }

            //Adding first point to the collection's tail.
            pointCollection.Add(pointCollection[0]);

            //Drawing strokes between points.
            var pentagone = new Stroke(pointCollection);
            return pointCollection;
        }
            
/*
            var pointCollection = new StylusPointCollection();
            double x = Math.Abs(anchor.X - cursor.X) / 2;                                                                //Center coords
            double y = Math.Abs(anchor.Y - cursor.Y) / 2;
            double angle = 20;
            int angleNum = 5;

            double div = x / y;

            for (int i = 0; i < 5; i++)
            {
                var point = new StylusPoint();
                double fi = 72;//Math.Atan((div) * Math.Tan(angle));
                point.X = (anchor.X + cursor.X) / 2 + (x * Math.Cos(fi));
                point.Y = (anchor.X + cursor.X) / 2 + (y * Math.Sin(fi));
                //angle = angle + 360 / angleNum;
                pointCollection.Add(point);
            }

            //Adding first point to the collection's tail.
            pointCollection.Add(pointCollection[0]);

            //Drawing strokes between points.
            return pointCollection;
            
        }
        */
        public Pentagon() : base() { }
    }
}
