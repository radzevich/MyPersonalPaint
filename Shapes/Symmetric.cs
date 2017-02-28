using System;

namespace PaintWPF
{
    abstract class Symmetric : Polygon
    {
        public Symmetric(Point anchor, Point cursor) : base (anchor, cursor)
        {
            try
            {
                if (Math.Abs(base.Anchor.X - Cursor.X) > Math.Abs(Anchor.Y - Cursor.Y))
                {
                    if (Anchor.Y > Cursor.Y)
                    {
                        Cursor.Y = Anchor.Y - Math.Abs(Anchor.X - Cursor.X);
                    }
                    else
                    {
                        Cursor.Y = Anchor.Y + Math.Abs(Anchor.X - Cursor.X);
                    }
                }
                else
                {
                    if (Anchor.X > Cursor.X)
                    {
                        Cursor.X = Anchor.X - Math.Abs(Anchor.Y - Cursor.Y);
                    }
                    else
                    {
                        Cursor.X = Anchor.X + Math.Abs(Anchor.Y - Cursor.Y);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
