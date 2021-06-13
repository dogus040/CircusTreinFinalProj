using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Herbivore : Animal
    {
        public Herbivore(AnimalSize animalSize)
        {
            this.AnimalSize = (int)animalSize;
        }
    }
}
