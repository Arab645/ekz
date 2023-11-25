namespace LAB8part3
{
    public abstract class TechProductFactory
    {
        public abstract ProductPart CreateScreen();
        public abstract ProductPart CreateProcessor();
        public abstract ProductPart CreateCamera();
    }
}