using System;
class Circle : Shape
{
    public Circle(double radious) : base(radious, radious) { }
    public override double CalcSurface()
    {
        return (this.Width *this.Height)*Math.PI;
    }
}
