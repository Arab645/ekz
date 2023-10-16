using System;
namespace LAB4part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();

            Animal lion = new Animal(100, 5, 1.5, "Lion");
            Animal tiger = new Animal(90, 6, 1.4, "Tiger");
            Plant oak = new Plant(50, 10, 3.0, "Oak");
            Microorganism bacteria = new Microorganism(10, 1, 0.01, "Bacteria");

            ecosystem.AddOrganism(lion);
            ecosystem.AddOrganism(tiger);
            ecosystem.AddOrganism(oak);
            ecosystem.AddOrganism(bacteria);

            ecosystem.SimulateInteractions();

            Console.WriteLine("Ecosystem simulation completed.");
        }
    }
}