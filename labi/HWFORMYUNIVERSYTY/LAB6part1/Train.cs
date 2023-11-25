using System;

namespace LAB6part1
{
    public class Train:Vehicle
    {
        public int TrackNumber { get; set; }

        public Train(int speed, int capacity, int trackNumber)
        {
            Speed = speed;
            Capacity = capacity;
            TrackNumber = trackNumber;
        }

        public override void Move()
        {
            Console.WriteLine($"Taking a train with speed: {Speed}, capacity: {Capacity} on track {TrackNumber}");
        }

        public override void PassengerBoarding()
        {
            Console.WriteLine("Passengers boarded the train.");
        }

        public override void PassengerDisembarking()
        {
            Console.WriteLine("Passengers disembarked from the train.");
        }
    }
}