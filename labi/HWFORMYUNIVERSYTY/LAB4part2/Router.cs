namespace LAB4part2
{
    using System;
    using System.Collections.Generic;

    public class Router : Computer, IConnectable
    {
        private List<Computer> connectedComputers;

        public Router(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
            connectedComputers = new List<Computer>();
        }

        public void Connect(Computer computer)
        {
            connectedComputers.Add(computer);
            Console.WriteLine($"{computer.IPAddress} connected to the router at {IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            connectedComputers.Remove(computer);
            Console.WriteLine($"{computer.IPAddress} disconnected from the router at {IPAddress}");
        }

        public void TransmitData(Computer computer, string data)
        {
            Console.WriteLine($"Data from {IPAddress} transmitted to {computer.IPAddress}: {data}");
        }

        public string ReceiveData()
        {
            return "Data from the router";
        }
    }
}