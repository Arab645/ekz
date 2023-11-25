using System;

namespace LAB6part1
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
        public abstract void PassengerBoarding();
        public abstract void PassengerDisembarking();
    }
}