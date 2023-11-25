using System;
namespace LAB8part3
{
    public class LaptopFactory : TechProductFactory
    {
        public override ProductPart CreateScreen()
        {
            return new Screen();
        }

        public override ProductPart CreateProcessor()
        {
            return new LaptopProcessor();
        }

        public override ProductPart CreateCamera()
        {
            return new Camera();
        }
    }

    public class LaptopProcessor : Processor
    {
        public void AdditionalLaptopMethod()
        {
            Console.WriteLine("Additional Laptop Method");
        }
    }
}