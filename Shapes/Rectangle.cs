﻿using System;

namespace UserShapes
{
    class Rectangle : Assymmetric
    {
        public Rectangle(Point anchor, Point cursor) : base(anchor, cursor)
        {
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }
    }
}
