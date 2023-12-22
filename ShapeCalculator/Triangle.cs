using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Triangle : IShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetArea()
        {
            double halfOfPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - Side1) * (halfOfPerimeter - Side2) * (halfOfPerimeter - Side3));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);

            double katet1 = sides[0];
            double katet2 = sides[1];
            double hypotenuse = sides[2];

            return PythagoreanTheorem(katet1, katet2, hypotenuse);
        }

        private bool PythagoreanTheorem(double katet1, double katet2, double hypotenuse) => Math.Pow(hypotenuse, 2) == Math.Pow(katet1, 2) + Math.Pow(katet2, 2);
    }
}
