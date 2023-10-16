namespace LAB4part3
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int NumberOfLanes { get; set; }
        public int TrafficLevel { get; set; }

        public Road(double length, double width, int numberOfLanes)
        {
            Length = length;
            Width = width;
            NumberOfLanes = numberOfLanes;
            TrafficLevel = 0;
        }
    }
}