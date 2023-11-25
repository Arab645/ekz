using System;
namespace LAB8part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a tech product to assemble (Phone/Laptop/Tablet):");
            string productType = Console.ReadLine().ToLower();

            TechProductFactory factory = null;

            switch (productType)
            {
                case "phone":
                    factory = new PhoneFactory();
                    break;
                case "laptop":
                    factory = new LaptopFactory();
                    break;
                case "tablet":
                    factory = new TabletFactory();
                    break;
                default:
                    Console.WriteLine("Invalid product type");
                    return;
            }

            ProductPart screen = factory.CreateScreen();
            ProductPart processor = factory.CreateProcessor();
            ProductPart camera = factory.CreateCamera();

            Console.WriteLine($"Assembling {productType}:");
            screen.Display();
            processor.Display();

            if (processor is LaptopProcessor laptopProcessor)
            {
                laptopProcessor.AdditionalLaptopMethod();
            }

            camera.Display();
        }
    }
}