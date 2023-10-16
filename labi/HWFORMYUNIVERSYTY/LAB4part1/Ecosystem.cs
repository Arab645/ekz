using System;
using System.Linq;
using System.Collections.Generic;

namespace LAB4part1

{
    public class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateInteractions()
        {
            foreach (var organism in organisms)
            {
                var potentialPreys = organisms.Where(o => o != organism);

                foreach (var prey in potentialPreys)
                {
                    if (organism is IPredator predator)
                    {
                        predator.Hunt(prey);
                    }

                    if (organism is IReproducible reproducible)
                    {
                        reproducible.Reproduce();
                    }
                }
            }
        }
    }
    public class LivingOrganism
    {
        public double Energy { get; set; }
        public int Age { get; set; }
        public double Size { get; set; }

        public LivingOrganism(double energy, int age, double size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }
    }
}