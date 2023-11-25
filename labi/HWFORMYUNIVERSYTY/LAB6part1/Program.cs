namespace LAB6part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(60, 4, "Gasoline");
            Bus bus = new Bus(40, 30, 101);
            Train train = new Train(80, 200, 1);

            TransportNetwork transportNetwork = new TransportNetwork();
            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            transportNetwork.ControlMovement();

            Route route = new Route { StartPoint = "City A", EndPoint = "City B" };
            transportNetwork.PassengerBoarding(route);
            transportNetwork.PassengerDisembarking(route);
        }
    }
}