using System;
using System.Collections.Generic;
using System.Text;

namespace Day4.Bike
{
    public class Bike
    {
        private int speed = 0;
        private double speedModifier = 1;
        private int speedLimit = 12;
        public int location = 0;

        public Bike()
        {

        }

        public Bike(double _speedModifier, int _speedLimit)
        {
            speedModifier = _speedModifier;
            speedLimit = _speedLimit;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public double GetSpeedModifier()
        {
            return speedModifier;
        }

        public int GetSpeedLimit()
        {
            return speedLimit;
        }

        public void Accelerate()
        {
            if (speed <= speedLimit - 1)
            {
                speed++;
            }
        }

        public void MoveForward()
        {
            location += speed;
        }
    }
}
