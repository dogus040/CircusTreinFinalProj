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

        public void doesAnimalFitIntoWagon(Wagon wagon, Animal animal)
        {
            if (wagon.Capacity >= (int)animal.AnimalSize)
            {
                wagon.Animals.Add(animal);
                int newCap = wagon.Capacity - (int)animal.AnimalSize;
                wagon.Capacity = newCap;
            }
        }
    }
}