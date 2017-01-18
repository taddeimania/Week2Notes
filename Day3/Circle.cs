using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Circle : Shape
    {
        public double diameter {
            get {
                return 2 * radius;
            }
        }

        public Circle(double _radius) : base(_radius)
        {
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
