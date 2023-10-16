using System;
namespace LAB4part1
{
    public class Animal : LivingOrganism, IPredator, IReproducible
    {
        public string Species { get; set; }

        public Animal(double energy, int age, double size, string species)
            : base(energy, age, size)
        {
            Species = species;
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine($"Animal {Species} preys on another organism.");
        }

        public void Reproduce()
        {
            Console.WriteLine($"Animal {Species} is multiplying");
        }
    }
}