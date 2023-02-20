using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.HeroClasses
{
    public class RangerClass : Hero
    {
        public RangerClass(string rangerName) : base(rangerName)
        {
            HeroAttribute rangerAttributesOnCreation = new(1, 7, 1);
            levelAttributes = rangerAttributesOnCreation;
        }
        private void IncreaseRangerAttributesLevelByLevelUp()
        {

            levelAttributes.strength += 1;
            levelAttributes.dexterity += 5;
            levelAttributes.intelligence += 1;
        }
        public override void LevelUp()
        {
            level++;
            IncreaseRangerAttributesLevelByLevelUp();
        }

        public override List<Weapons> validWeaponTypes
        {
            get { return new List<Weapons> { Weapons.Bow }; }
        }
        public override List<Armor> validArmorTypes
        {
            get { return new List<Armor> { Armor.Leather,Armor.Mail }; }
        }
        public override string ClassName
        {
            get { return "Ranger"; }
        }
    }
}
