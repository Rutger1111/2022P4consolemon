using System;
using System.Collections.Generic;
using System.Text;

namespace consolemon
{
    class Consolemon
    {
        internal int Health = 100;
        internal int Energy = 10;
        internal string Naam = "chorizord";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        internal void TakeDamage(int damage)
        {
            Health -= damage;
        }



        internal void depleteEnergy(int Energycost)
        {
            Energy -= Energycost;
        }
    }
}
