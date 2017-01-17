using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
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
            // Console.WriteLine(peanut.name);

            var casey = new Dog("Casey");
            var spaghetti = new Dog("Spaghetti");
            spaghetti.HappyBirthday();
            var rex = new Dog("Rex");

            // Console.WriteLine(peanut);
            peanut.AddFriend(casey);
            peanut.AddFriend(spaghetti);
            peanut.AddFriend(spaghetti);
            peanut.AddFriend(rex);

            peanut.GetDogFriends();
            peanut.RemoveFriend(spaghetti);
            peanut.GetDogFriends();

            Console.ReadLine();


        }
    }
}
