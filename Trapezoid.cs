using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class Trapezoid : Shape, IShapeArea, ICircumscribedCircle
    {
        public double Base1 { get; private set; }
        public double Base2 { get; private set; }
        public double Height { get; private set; }

        public Trapezoid(double base1, double base2, double height) : base("Trapezoid")
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public double CalculatePerimeter()
        {
            return Base1 + Base2 + 2 * Math.Sqrt(((Base1 - Base2) / 2) * ((Base1 - Base2) / 2) + Height * Height);
        }

        public double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public double CalculateCircumscribedCircleRadius()
        {
            return Math.Sqrt((Height * Height + (Base1 - Base2) * (Base1 - Base2)) / 4 + (Base1 + Base2) * (Base1 + Base2) / 4) / 2;
        }
    }
}
