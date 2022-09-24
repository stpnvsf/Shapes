using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Triangle : IShape
    {
        private readonly bool _isRight;
        public bool IsRight { get { return _isRight; } }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException("Сторона а не может быть меньше нуля");
            if (b <= 0)
                throw new ArgumentException("Сторона b не может быть меньше нуля");
            if(c <= 0)
                throw new ArgumentException("Сторона c не может быть меньше нуля");
            
            double maxSide = Math.Max(a, Math.Max(b, c));
            double perimeter = a + b + c;

            if ((perimeter - maxSide) - maxSide <= 0)
                throw new ArgumentException("Треугольник с такими сторонами не существует");

            SideA = a;
            SideB = b;
            SideC = c;
            _isRight = isRight();
        }
        public double getArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / (double)2;
            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - SideA)
                * (semiPerimeter - SideB)
                * (semiPerimeter - SideC));
        }

        private bool isRight()
        {
            if ((Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                || (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                || (Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2)))
                return true;
            return false;

        }
    }
}
