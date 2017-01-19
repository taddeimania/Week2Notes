using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bike
{
    public class Program
    {

        public static bool TickRace(Bike bike, bool isRunning, int finishLine)
        {
            if (bike.location >= finishLine)
            {
                isRunning = false;
            }
            else
            {
                bike.Accelerate();
                bike.MoveForward();
            }
            return isRunning;
        }

        static void Main(string[] args)
        {
            List<Bike> raceBikes = BikeFactory.CreateXBikes(40);
            int finishLine = 1000;
            bool isRunning = true;

            while(isRunning)
            {
                for (int i = 0; i < raceBikes.Count; i++)
                {
                    var currentBike = raceBikes[i];
                    isRunning = TickRace(currentBike, isRunning, finishLine);
                }
            }

            foreach (var bike in raceBikes)
            {
                Console.WriteLine(bike.location);
            }
        }
    }
}
