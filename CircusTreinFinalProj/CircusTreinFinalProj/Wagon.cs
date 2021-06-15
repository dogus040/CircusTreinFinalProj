using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Wagon
    {

        private List<Animal> animals;
        private int capacity = 10;
        Train train = new Train();
        public List<Animal> Animals
        {
            get { return animals; } set { animals = value; }
        }

        public Wagon()
        {
            animals = new List<Animal>();
        }

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public bool doesAnimalFitIntoWagon(Animal animal)
        {
            if (capacity >= (int)animal.AnimalSize)
            {
                int newCap = capacity - (int)animal.AnimalSize;
                capacity = capacity - newCap;
                return true;
            }
            else return false;
        }

        public void addAnimalToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            train.addWagonToTrainWithAnimal(animal, wagon);
        }
    }
}