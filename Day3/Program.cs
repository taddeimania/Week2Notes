using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(4, 10);
            double squareArea = square.Area();
            Console.WriteLine(squareArea);

            var circle = new Circle(10);
            double circleArea = circle.Area();
            Console.WriteLine(circleArea);

            var nonogramarticle = new Shape();
            double nonArea = nonogramarticle.Area();
            Console.WriteLine(nonArea);
        }
    }
}
