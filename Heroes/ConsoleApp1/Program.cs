using ConsoleApp1.Factories;
using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero_elf = new Hero(new ElfFactory());
            hero_elf.Hit();
            hero_elf.Run();
            Console.WriteLine("--------------");
            Hero hero_warr = new Hero(new WarriorFactory());
            hero_warr.Hit();
            hero_warr.Run();
        }
    }
}
