namespace LAB8part3
{
    using System;

    public abstract class ProductPart
    {
        public abstract void Display();
    }

    public class Screen : ProductPart
    {
        public override void Display()
        {
            Console.WriteLine("Screen Displaying");
        }
    }

    public class Processor : ProductPart
    {
        public override void Display()
        {
            Console.WriteLine("Processor Processing");
        }
    }

    public class Camera : ProductPart
    {
        public override void Display()
        {
            Console.WriteLine("Camera Capturing");
        }
    }
}