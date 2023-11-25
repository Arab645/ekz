using System;
using System.Collections.Generic;

namespace LAB6part1
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlMovement()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void PassengerBoarding(Route route)
        {
            Console.WriteLine($"Passengers boarding for route from {route.StartPoint} to {route.EndPoint}");
        }

        public void PassengerDisembarking(Route route)
        {
            Console.WriteLine($"Passengers disembarking for route from {route.StartPoint} to {route.EndPoint}");
        }
    }

}