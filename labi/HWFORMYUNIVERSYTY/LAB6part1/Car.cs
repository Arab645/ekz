using System;

namespace LAB6part1
{
    public class Car:Vehicle
    {
        public string FuelType { get; set; }

        public Car(int speed, int capacity, string fuelType)
        {
            Speed = speed;
            Capacity = capacity;
            FuelType = fuelType;
        }

        public override void Move()
        {
            Console.WriteLine($"Driving a car with speed: {Speed}, capacity: {Capacity}, fuel type: {FuelType}");
        }

        public override void PassengerBoarding()
        {
            Console.WriteLine("Passengers boarded the car.");
        }

        public override void PassengerDisembarking()
        {
            Console.WriteLine("Passengers disembarked from the car.");
        }
    }
}