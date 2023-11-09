using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class Rhombus : Shape, IShapeArea, IInscribedCircle, ICircumscribedCircle
    {
        public double Side { get; private set; }

        public Rhombus(double side) : base("Rhombus")
        {
            Side = side;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculateInscribedCircleRadius()
        {
            return Side / 2;
        }

        public double CalculateCircumscribedCircleRadius()
        {
            return Side / (2 * Math.Sin(Math.PI / 4));
        }
    }
}
