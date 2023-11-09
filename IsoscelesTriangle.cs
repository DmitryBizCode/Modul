using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class IsoscelesTriangle : Shape, IShapeArea, IInscribedCircle
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public IsoscelesTriangle(double ibase, double height) : base("Isosceles Triangle")
        {
            Base = ibase;
            Height = height;
        }

        public double CalculatePerimeter()
        {
            return 2 * Base + Math.Sqrt(Base * Base + 4 * Height * Height);
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculateInscribedCircleRadius()
        {
            return 2 * CalculateArea() / (Base + Math.Sqrt(Base * Base + 4 * Height * Height));
        }
    }
}
