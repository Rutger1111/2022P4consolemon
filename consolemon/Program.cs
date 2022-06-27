using System;

namespace consolemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Consolemon Consolemona = new Consolemon();
            Consolemon Consolemonb = new Consolemon();

            Consolemona.Health = 100;
            Consolemona.Energy = 10;
            Consolemona.Naam = "chorizord";
            Consolemona.monstertype = "monster";
            Consolemonb.Health = 100;
            Consolemonb.Energy = 10;
            Consolemonb.Naam = "chorizord";
            Consolemonb.monstertype = "monster";

            Skill skilla = new Skill();
            Skill skillb = new Skill();

            skilla.skillDamage = 10;
            skilla.skillEnegry = 10;
            skilla.skillWeakness = element.fire;
            skillb.skillDamage = 10;
            skillb.skillEnegry = 10;
            skillb.skillWeakness = element.fire;

            Consolemona.skills.Add(skilla);
            Consolemonb.skills.Add(skillb);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(Consolemona, Consolemonb);
        }
    }

}
