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
            wagons = new List<Wagon>() { new Wagon() };
        }

        public void spreadAnimals()
        {
            foreach (Animal animal in Animals)
            {
                SearchForWagon(animal).addAnimalToWagon(animal);
            }
        }
        public Wagon SearchForWagon(Animal animal)
        {
            foreach (Wagon item in Wagons)
            {
                if (item.doesAnimalFitIntoWagon(animal) && animal.isAnimalSafe(item.Animals))
                {
                    return item;
                }
            }
            Wagon wagon = new Wagon();
            wagons.Add(wagon);
            return wagon;
        }

        public void addWagonToWagonList(Wagon wagon)
        {
            wagons.Add(wagon);
        }
    }
}
