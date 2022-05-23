using System;
using System.Collections.Generic;
using System.Text;

namespace consolemon
{
    class Skills
    {
        internal int Damage = 10;
        internal int EnergyCost = 1;
        internal string Naam = "chorizord";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        internal void UseOn(Consolemon target, Consolemon caster)
        {
            target.TakeDamage(Damage);
            caster.depleteEnergy(EnergyCost);
        }
    }
}

