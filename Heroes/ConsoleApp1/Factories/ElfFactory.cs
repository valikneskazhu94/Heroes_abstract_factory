using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.Factories
{
    public class ElfFactory:HeroFactory
    {
        public override Movement createMovement()
        {
            return new FlyMovement();
        }
        public override Weapon createWeapon()
        {
            return new Crossbow();
        }
    }
}
