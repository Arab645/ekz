using System;
using System.Collections.Generic;
namespace LAB4part3
{
    public class TrafficSimulation
    {
        private Road road;
        private List<Vehicle> vehicles;

        public TrafficSimulation(Road road)
        {
            this.road = road;
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SimulateTraffic()
        {
            Console.WriteLine($"Simulating traffic on a road of length {road.Length} meters with {road.NumberOfLanes} lanes.");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"A {vehicle.Type} is moving at {vehicle.Speed} m/s.");
            }
        }
    }
}