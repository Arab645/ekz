using System;
using System.Collections.Generic;
namespace LAB4part2
{
    public class Server : Computer, IConnectable
    {
        private List<Computer> connectedComputers;

        public Server(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
            connectedComputers = new List<Computer>();
        }

        public void Connect(Computer computer)
        {
            connectedComputers.Add(computer);
            Console.WriteLine($"{computer.IPAddress} connected to the server at {IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            connectedComputers.Remove(computer);
            Console.WriteLine($"{computer.IPAddress} disconnected from the server at {IPAddress}");
        }

        public void TransmitData(Computer computer, string data)
        {
            Console.WriteLine($"Data from {IPAddress} transmitted to {computer.IPAddress}: {data}");
        }

        public string ReceiveData()
        {
            return "Data from the server";
        }
    }
}