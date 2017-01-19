using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bike
{
    public class BikeFactory
    {
        public static List<Bike> CreateXBikes(int count)
        {
            var bikeList = new List<Bike>();
            var rng = new Random();
            for (int i = 0; i < count; i++)
            {
                bool isRandomBike = rng.Next(10) < 4;

                if (isRandomBike)
                {
                    double speedModifier = rng.Next(8, 13) / 10;
                    int speedLimit = rng.Next(7, 20);
                    bikeList.Add(new Bike(speedModifier, speedLimit));
                }

                bikeList.Add(new Bike());
            }
            return bikeList;
        }
    }
}
