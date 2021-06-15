using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Train
    {
        private List<Animal> animals;
        private List<Wagon> wagons;

        public List<Animal> Animals
        {
            get { return animals; }
        }

        public List<Wagon> Wagons
        {
            get { return wagons; }
        }

        public Train()
        {
            animals = new List<Animal>();
            wagons = new List<Wagon>();
        }

        public void addAnimalToWagon(Animal animal, Wagon wagon)
        {
            if (animal.isAnimalSafe(Animals) == true && wagon.doesAnimalFitIntoWagon(animal) == true)
            {
                Animals.Add(animal);
            }
            else wagon.addAnimalToNewWagon(animal);
        }

        public void spreadAnimals(Wagon wagon)
        {
            foreach (Animal animal in Animals)
            {
                addAnimalToWagon(animal, wagon);
            }
        }

        public void addWagonToTrainWithAnimal(Animal animal, Wagon wagon)
        {
            addAnimalToWagon(animal, wagon);
            wagons.Add(wagon);
        }
    }
}
