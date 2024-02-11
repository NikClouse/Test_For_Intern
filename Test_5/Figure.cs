using System;

namespace Test_5
{
    public abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract string GetInfo();
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
        public override string GetInfo() => $"Rectangle: width = {Width}, height = {Height}";
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public override double GetPerimeter() => 2 * Math.PI * Radius;
        public override string GetInfo() => $"Circle: radius = {Radius}";
    }

    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double GetPerimeter() => SideA + SideB + SideC;
        public override string GetInfo() => $"Triangle: sideA = {SideA}, sideB = {SideB}, sideC = {SideC}";
    }
}
