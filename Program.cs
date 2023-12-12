namespace LAB4part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Server server1 = new Server("192.168.1.1", 1000, "Windows Server");
            Server server2 = new Server("192.168.1.2", 1200, "Linux Server");

            Workstation workstation1 = new Workstation("192.168.2.1", 500, "Windows Workstation");
            Workstation workstation2 = new Workstation("192.168.2.2", 600, "Linux Workstation");

            Router router = new Router("192.168.0.1", 800, "Router");

            server1.Connect(workstation1);
            server2.Connect(workstation2);

            workstation1.TransmitData(server1, "Request from Workstation 1");
            workstation2.TransmitData(server2, "Request from Workstation 2");

            workstation1.Connect(router);
            workstation1.TransmitData(router, "Request through Router");

            server1.Disconnect(workstation1);
            server2.Disconnect(workstation2);
            workstation1.Disconnect(router);
        }
    }
}