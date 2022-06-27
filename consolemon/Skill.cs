namespace consolemon
{
    class Skill
    {
        internal element skillWeakness;
        internal int skillEnegry = 10;
        internal int skillDamage = 10;

        public void UseOn(Consolemon target, Consolemon caster)
        {
            caster.depleteEnergy(skillEnegry);
            target.TakeDamage(skillDamage);
        }

        internal Skill()
        {

        }

        internal Skill(Skill flamethrower)
        {
            this.skillDamage = flamethrower.skillDamage;
            this.skillEnegry = flamethrower.skillEnegry;
            this.skillWeakness = flamethrower.skillWeakness;
        }
    }
}
