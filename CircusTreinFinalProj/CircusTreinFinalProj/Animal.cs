using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public abstract class Animal
    {
        private AnimalSizeEnum animalSize;
        public AnimalSizeEnum AnimalSize
        {
            get { return animalSize; } set { animalSize = value; }
        }

        public abstract bool isAnimalSafe(List<Animal> WagonAnimals);
    }
}
