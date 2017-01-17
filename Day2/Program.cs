using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    // Class Definition
    class Dog
    {
        private int Age;
        public string name;

        public Dog(string _name)
        {
            Age = 0;
            name = _name;
        }

        public void HappyBirthday()
        {
            Age++;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetAgeDogYears()
        {
            return Age * 7;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it works");
            var peanut = new Dog("Peanut");
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            var age = peanut.GetAge();
            var ageDogYears = peanut.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
            Console.WriteLine(peanut.name);
            Console.ReadLine();

        }
    }
}
