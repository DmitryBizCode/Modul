using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public class PentagonalPyramid : Shape, I3D
    {
        public double BaseSide { get; private set; }
        public double SlantHeight { get; private set; }

        public PentagonalPyramid(double baseSide, double slantHeight) : base("Pentagonal Pyramid")
        {
            BaseSide = baseSide;
            SlantHeight = slantHeight;
        }

        public double CalculateArea()
        {
            double apothem = Math.Sqrt((BaseSide / 2) * (BaseSide / 2) + SlantHeight * SlantHeight);
            double perimeter = 5 * BaseSide;
            return 0.5 * perimeter * apothem + BaseSide * BaseSide;
        }

        public double CalculateVolume()
        {
            return (1.0 / 3.0) * BaseSide * BaseSide * SlantHeight;
        }
    }
}
