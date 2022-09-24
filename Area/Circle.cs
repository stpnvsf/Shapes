using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Circle : IShape
    {
        public double Radius { get; }
        
        public Circle(double r) 
        {
            if (r <= 0)
                throw new ArgumentException("Недопустимое значение радиуса");
                
            Radius = r;

        }

        public double getArea()
        {
            return Math.PI * Math.Pow(Radius, (double)2);
        }

    }

}
