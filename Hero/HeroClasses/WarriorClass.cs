using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.HeroClasses
{
    public class WarriorClass : Hero
    {
        public WarriorClass(string warriorName) : base(warriorName)
        {
            HeroAttribute warriorAttributesOnCreation = new(1, 7, 1);
            levelAttributes = warriorAttributesOnCreation;
        }
        private void IncreaseWarriorAttributesLevelByLevelUp()
        {

            levelAttributes.strength += 1;
            levelAttributes.dexterity += 5;
            levelAttributes.intelligence += 1;
        }
        public override void LevelUp()
        {
            level++;
            IncreaseWarriorAttributesLevelByLevelUp();
        }

        public override List<Weapons> validWeaponTypes
        {
            get { return new List<Weapons> { Weapons.Axe, Weapons.Hammer, Weapons.Sword }; }
        }
        public override List<Armor> validArmorTypes
        {
            get { return new List<Armor> { Armor.Plate, Armor.Mail }; }
        }
        public override string ClassName
        {
            get { return "Warrior"; }
        }
    }
}
