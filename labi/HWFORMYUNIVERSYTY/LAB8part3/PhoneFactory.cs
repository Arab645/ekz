namespace LAB8part3
{
    public class PhoneFactory : TechProductFactory
    {
        public override ProductPart CreateScreen()
        {
            return new Screen();
        }

        public override ProductPart CreateProcessor()
        {
            return new Processor();
        }

        public override ProductPart CreateCamera()
        {
            return new Camera();
        }
    }
}