namespace LAB4part3
{
    public enum VehicleType
    {
        Car,
        Truck,
        Bus
    }

    public class Vehicle
    {
        public VehicleType Type { get; set; }
        public double Speed { get; set; }
        public double Size { get; set; }

        public Vehicle(VehicleType type, double speed, double size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }
    }
}