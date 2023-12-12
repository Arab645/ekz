using System;
namespace LAB4part2
{
    public class Workstation : Computer, IConnectable
    {
        private Computer connectedToServer;

        public Workstation(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
        }

        public void Connect(Computer computer)
        {
            connectedToServer = computer;
            Console.WriteLine($"{IPAddress} connected to the server at {computer.IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            connectedToServer = null;
            Console.WriteLine($"{IPAddress} disconnected from the server at {computer.IPAddress}");
        }

        public void TransmitData(Computer computer, string data)
        {
            if (connectedToServer != null)
            {
                Console.WriteLine($"Data from {IPAddress} transmitted to the server at {connectedToServer.IPAddress}: {data}");
            }
            else
            {
                Console.WriteLine($"{IPAddress} is not connected to any server.");
            }
        }

        public string ReceiveData()
        {
            return "Data from the workstation";
        }
    }
}