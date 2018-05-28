using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public abstract class HeroFactory
    {
        public abstract Movement createMovement();
        public abstract Weapon createWeapon();
    }
}
