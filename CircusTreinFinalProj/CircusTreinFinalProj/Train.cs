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
                //doe iets zodat je door elke wagon gaat en checkt
                //oof hij erin past
                SearchForWagon(animal).;
            }
        }
        public Wagon SearchForWagon(Animal animal)
        {
            foreach (Wagon item in Wagons)
            {
                if (item.doesAnimalFitIntoWagon(animal) )
                {
                    return item;
                }
            }
            Wagon wagon = new Wagon();
            addWagonToWagonList(wagon);
            return wagon;
        }

        public void addWagonToWagonList(Wagon wagon)
        {
            wagons.Add(wagon);
        }
    }
}
