using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.HeroClasses
{
    internal class HeroAttribute
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }

        public HeroAttribute()
        {
            strength = 0;
            dexterity = 0;
            intelligence = 0;
        }
        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
        
        public HeroAttribute addHeroAttributes(HeroAttribute attributes)
        {
            this.strength+= attributes.strength;
            this.dexterity+= attributes.dexterity;
            this.intelligence+= attributes.intelligence;
            return this;
        }
    }
}
