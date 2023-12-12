namespace LAB4part2
{
    public interface IConnectable
    {
        void Connect(Computer computer);
        void Disconnect(Computer computer);
        void TransmitData(Computer computer, string data);
        string ReceiveData();
    }
}