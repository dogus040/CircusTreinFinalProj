using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Herbivore : Animal
    {
        public Herbivore(AnimalSizeEnum animalSize)
        {
            AnimalSize = animalSize;
        }

        public Herbivore()
        {

        }

        public override bool isAnimalSafe(List<Animal> WagonAnimals)
        {
            foreach (Animal animal in WagonAnimals)
            {
                if (animal.GetType().Name == nameof(Carnivore)) // controleer of je te maken hebt met een carnivoor
                {
                    if (AnimalSize <= animal.AnimalSize)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            return "H" + (int)AnimalSize;
        }
    }
}
