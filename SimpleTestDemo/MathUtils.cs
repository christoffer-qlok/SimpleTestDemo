using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestDemo
{
    public static class MathUtils
    {
        public static double GetRectangleArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }

        public static double GetHypotenuse(double a, double b)
        {
            double cSquared = a * a + b * b;
            return Math.Sqrt(cSquared);
        }

        public static double GetRectangleSide(double area, double side)
        {
            if(side == 0)
            {
                throw new ArgumentException("Cannot be zero", nameof(side));
            }
            return area / side;
        }
    }
}
