using ConsoleApp1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
   public class Hero
    {
        Weapon _weapon;
        Movement _movement;
        public Hero(HeroFactory _herofactory )
        {
            _weapon = _herofactory.createWeapon();
            _movement = _herofactory.createMovement();
        }
        public void Run()
        {
            _movement.Move();
        }
        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
