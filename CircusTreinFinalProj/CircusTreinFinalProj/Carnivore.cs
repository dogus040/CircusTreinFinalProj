using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Carnivore : Animal
    {
        public Carnivore(AnimalSizeEnum animalSize)
        {
             AnimalSize = animalSize;
        }

        public override string ToString()
        {
            return "C" + (int)AnimalSize;
        }

        public override bool isAnimalSafe(List<Animal> WagonAnimals)
        {
            foreach (Animal animal in WagonAnimals)
            {
                if (AnimalSize >= animal.AnimalSize)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
