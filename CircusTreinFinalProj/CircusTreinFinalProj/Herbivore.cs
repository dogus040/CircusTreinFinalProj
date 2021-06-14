using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Herbivore : Animal
    {
        public Herbivore(AnimalSizeEnum animalSize)
        {
            AnimalSize = animalSize;
        }

        public override string ToString()
        {
            return "H" + (int)AnimalSize;
        }
    }
}
