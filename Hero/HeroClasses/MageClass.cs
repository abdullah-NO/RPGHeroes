using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.HeroClasses
{
    internal class MageClass : Hero
    {
        public HeroAttribute mageAttribute = new();
        public MageClass() : base("Abu The Mage")
        {
            mageAttribute.strength = 1;
            mageAttribute.dexterity = 1;
            mageAttribute.intelligence = 8;
        }
        private void IncreaseMageAttributesLevel()
        {
            mageAttribute.strength += 1;
            mageAttribute.dexterity += 1;
            mageAttribute.intelligence += 5;
        }
        public override void LevelUp()
        {
            base.level++;
            IncreaseMageAttributesLevel();
            throw new NotImplementedException();
        }
    }
}
