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
        public List<Dog> friends = new List<Dog>();

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

        public void AddFriend(Dog friend)
        {
            if (friends.Contains(friend))
            {
                Console.WriteLine($"Dog {friend} is already our friend");
            }
            else
            {
                friends.Add(friend);
            }
        }

        public void RemoveFriend(Dog friend)
        {
            friends.Remove(friend);
        }

        public void GetDogFriends()
        {
            Console.WriteLine(string.Join(", ", friends));
        }

        public override string ToString()
        {
            return $"{name}: {Age}";
        }
    }
}
