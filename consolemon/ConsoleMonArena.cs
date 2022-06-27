using System;
using System.Collections.Generic;
using System.Text;

namespace consolemon
{
    class ConsoleMonArena
    {
        public void DoBattle(Consolemon a, Consolemon b)
        {
            Random random = new Random();

            Skill skilla = a.skills[random.Next(a.skills.Count)];
            Skill skillb = b.skills[random.Next(b.skills.Count)];

            while (a.Health > 0 || b.Health > 0)
            {
                skilla.UseOn(b, a);
                skillb.UseOn(a, b);

                Console.WriteLine(a.Health);
                Console.WriteLine(b.Health);
            }
        }
    }
}
