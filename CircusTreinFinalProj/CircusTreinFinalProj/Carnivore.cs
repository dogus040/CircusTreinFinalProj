﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinFinalProj
{
    public class Carnivore : Animal
    {
        public Carnivore(AnimalSize animalSize)
        {
             AnimalSize = animalSize;
        }

        public override string ToString()
        {
            return "C" + (int)AnimalSize;
        }
    }
}
