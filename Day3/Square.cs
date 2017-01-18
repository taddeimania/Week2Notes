using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Square : Shape
    {
        public Square(double _height, double _width) : base(_height, _width)
        {
        }

        public override double Area()
        {
            return height * width;
        }
    }
}
