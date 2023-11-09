using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork
{
    public interface IShapeArea : IPerimeter
    {
        double CalculateArea();
    }
}
