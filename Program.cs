using System;
using CSharp___POO.src.Entities;

namespace CSharp___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 24, "Knight");
         

            Console.Write(hero);
            System.Console.Write(hero.Attack());
        }
    }
}
