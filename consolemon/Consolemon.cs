using System;
using System.Collections.Generic;
using System.Text;

namespace consolemon
{
    enum element
    {
        fire,
        rock,
        ground,
        grass
    }
    class Consolemon
    {
        element weakness;
        
        internal List<Skill> skills = new List<Skill>();
        internal string monstertype;
        internal int Health = 100;
        internal int Energy = 10;
        internal string Naam = "chorizord";




        internal void TakeDamage(int damage)
        {
            Health -= damage;
        }



        internal void depleteEnergy(int Energycost)
        {
            Energy -= Energycost;
        }
        internal Consolemon()
        {

        }

        internal Consolemon(Consolemon copyFrom)
        {
            this.Health = copyFrom.Health;
            this.Energy = copyFrom.Energy;
            this.weakness = copyFrom.weakness;

            System.Collections.IList list = copyFrom.skills;
            for (int i = 0; i < list.Count; i++)
            {
                Skill spell = (Skill)list[i];
                Skill flamethrowerClone = new Skill(skills[1]);
                skills.Add(flamethrowerClone);
            }
        }
    }
}
