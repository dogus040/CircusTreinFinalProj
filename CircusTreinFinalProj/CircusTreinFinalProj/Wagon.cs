using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        private int capacity = 10;

        public List<Animal> Animals
        {
            get { return animals; }
        }

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public bool doesAnimalFitIntoWagon(Animal animal)
        {
            if (capacity >= (int)animal.AnimalSize)
            {
                Animals.Add(animal);
                int newCap = capacity - (int)animal.AnimalSize;
                capacity = capacity - newCap;
                return true;
            }
            else
            {
                new Wagon();
                return false;
            }
        }
    }
}