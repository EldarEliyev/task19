using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Circle
    {
        public const double Pi = Math .PI;  
        public double CalculateAreaOfCircle(double radius)
        {
            return radius *radius *Pi;
        }

    }
}
