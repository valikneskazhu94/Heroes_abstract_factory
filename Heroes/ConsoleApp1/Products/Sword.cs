using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
   public class Sword:Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Hit by sword!Bitch.");
        }
    }
}
