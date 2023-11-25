using System;

namespace LAB6part1
{
    public class Human:Vehicle
    {
        public Human(int speed)
        {
            Speed = speed;
            Capacity = 1;
        }

        public override void Move()
        {
            Console.WriteLine($"Walking with speed: {Speed}");
        }

        public override void PassengerBoarding()
        {
            Console.WriteLine("One passenger boarded.");
        }

        public override void PassengerDisembarking()
        {
            Console.WriteLine("One passenger disembarked.");
        }
    }
}