﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private int boarBitSize = 2;
        public Boar(string name, Point location)
            : base(name, location, 4)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal!=null)
            {
                if (this.Size >= animal.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }    
            }
            return 0;
        }

        public int EatPlant(Plant p)
        {
            if (p != null)
            {
                this.Size++ ;
                return p.GetEatenQuantity(this.boarBitSize);
            }

            return 0;
        }
    }
}