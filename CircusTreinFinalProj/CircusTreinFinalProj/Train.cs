using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Train
    {
        Wagon wagon = new Wagon();
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public List<Animal> Animals
        {
            get { return animals; }
        }

        public void addWagon()
        {
            wagons.Add(wagon.createNewWagonWithEmptyList());
        }

        /* public Wagon addNewWagonToTrain()
        {
            Wagon wagon = new Wagon();
            wagon.Animals = new List<Animal>();
            wagons.Add(wagon);
            return wagon;
        } */
    }
}
