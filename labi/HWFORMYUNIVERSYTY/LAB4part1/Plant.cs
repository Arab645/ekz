using System;
namespace LAB4part1
{
    public class Plant : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public Plant(double energy, int age, double size, string type)
            : base(energy, age, size)
        {
            Type = type;
        }

        public void Reproduce()
        {
            Console.WriteLine($"A plant of type {Type} reproduces.");
        }
    }
}