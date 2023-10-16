namespace LAB4part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Road cityRoad = new Road(5000, 3, 2);
            Vehicle car1 = new Vehicle(VehicleType.Car, 25, 4);
            Vehicle truck1 = new Vehicle(VehicleType.Truck, 15, 8);
            Vehicle bus1 = new Vehicle(VehicleType.Bus, 20, 12);
            TrafficSimulation simulation = new TrafficSimulation(cityRoad);
            simulation.AddVehicle(car1);
            simulation.AddVehicle(truck1);
            simulation.AddVehicle(bus1);
            simulation.SimulateTraffic();
        }
    }
}