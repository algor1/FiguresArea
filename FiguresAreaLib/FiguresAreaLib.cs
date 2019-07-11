using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureasArea
{
    public class FiguresAreaLib
    {
        public double CircleArea(double r)
        {
            if (r < 0) new ArgumentException("radius can't be negative");
                       
            return 2 * Math.PI * r * r;
        }
        public double TriangleArea(double a,double b,double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a) new ArgumentException("Wrong size of triangle sides");

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
