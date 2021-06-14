using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Train
    {
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public List<Animal> Animals
        {
            get { return animals; }
        }
    }
}
