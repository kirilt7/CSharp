﻿using System;
class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height) { }
    public override double CalcSurface()
    {
        return (this.Width + this.Height);
    }
}
