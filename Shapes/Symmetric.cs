using System;

namespace PaintWPF
{
    abstract class Symmetric : Polygon
    {
        public Symmetric(Point anchor, Point cursor) : base (anchor, cursor)
        {
                int length = Math.Max(Math.Abs(Anchor.X - Cursor.X), Math.Abs(Anchor.Y - Cursor.Y));

                if (Anchor.Y > Cursor.Y)
                {
                      Cursor.Y = Anchor.Y - length;
                }
                else
                {
                    Cursor.Y = Anchor.Y + length;
                }      
                if (Anchor.X > Cursor.X)
                {
                      Cursor.X = Anchor.X - length;
                }
                else
                {
                      Cursor.X = Anchor.X + length;
                }  
        }
    }
}
