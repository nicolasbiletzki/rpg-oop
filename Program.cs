using System;
using CSharp___POO.src.Entities;

namespace CSharp___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 24, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "Wizard");
            
         

            Console.WriteLine(hero);
            System.Console.WriteLine(hero.Attack());
            System.Console.WriteLine(wizard);
            System.Console.WriteLine(wizard.Attack(5));
        }
    }
}
