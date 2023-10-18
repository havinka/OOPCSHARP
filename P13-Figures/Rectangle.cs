using System;
namespace P13_Figures
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }

        public double Width { get; set; }


        public override double CalculateArea()
        {
            return this.Height * this.Width;

        }

        public override double CalculatePerimeter()
        {
            return  2 * this.Height + this.Width;
        }

        public override string Draw()
        {
            return base.Draw() + "  I am a shitty rectangle";
        }


    }
}

