using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Wagon
    {

        private List<Animal> animals;
        private int capacity = 10;
        private int iCounter = 0;
        public List<Animal> Animals
        {
            get { return animals; } set { animals = value; }
        }

        public Wagon()
        {
            iCounter++;
            animals = new List<Animal>();
        }

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public bool doesAnimalFitIntoWagon(Animal animal)
        {
            if (capacity >= (int)animal.AnimalSize)
            {
                return true;
            }
            else return false;
        }

        public void decreaseWagonCapacity(Animal animal)
        {
            int newCap = capacity - (int)animal.AnimalSize;
            capacity = newCap;
        }

        public void addAnimalToWagon(Animal animal)
        {
            if (doesAnimalFitIntoWagon(animal))
            {
                decreaseWagonCapacity(animal);
                Animals.Add(animal);
            }
        }

        public override string ToString()
        {
            return "Wagon " + iCounter;
        }

    }
}