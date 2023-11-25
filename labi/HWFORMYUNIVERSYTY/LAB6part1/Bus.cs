using System;
namespace LAB6part1
{
    public class Bus:Vehicle
    {
        public int RouteNumber { get; set; }

        public Bus(int speed, int capacity, int routeNumber)
        {
            Speed = speed;
            Capacity = capacity;
            RouteNumber = routeNumber;
        }

        public override void Move()
        {
            Console.WriteLine($"Taking a bus with speed: {Speed}, capacity: {Capacity} on route {RouteNumber}");
        }

        public override void PassengerBoarding()
        {
            Console.WriteLine("Passengers boarded the bus.");
        }

        public override void PassengerDisembarking()
        {
            Console.WriteLine("Passengers disembarked from the bus.");
        }
    }
}