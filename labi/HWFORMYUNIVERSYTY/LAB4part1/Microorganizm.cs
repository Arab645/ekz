using System;
namespace LAB4part1
{
    public class Microorganism : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public Microorganism(double energy, int age, double size, string type)
            : base(energy, age, size)
        {
            Type = type;
        }

        public void Reproduce()
        {
            Console.WriteLine($"Microorganism type {Type} is multipluing.");
        }
    }
}