using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;

namespace RPGHeroes.Hero.HeroClasses
{
    public class MageClass : Hero
    { 
        public MageClass(string mageName) : base(mageName)
        {
            HeroAttribute mageAttributesOnCreation = new(1, 1, 8);
            levelAttributes = mageAttributesOnCreation;
        }
        private void IncreaseMageAttributesLevelByLevelUp()
        {
            
            levelAttributes.strength += 1;
            levelAttributes.dexterity += 1;
            levelAttributes.intelligence += 5;
        }
        public override void LevelUp()
        {
            level++;
            IncreaseMageAttributesLevelByLevelUp();
        }

        public override List<Weapons> validWeaponTypes
        {
            get { return new List<Weapons> { Weapons.Wand, Weapons.Staff }; }
        }
        public override List<Armor> validArmorTypes
        {
            get { return new List<Armor> { Armor.Cloth}; }
        }
        public override string ClassName
        {
            get { return "Mage"; }
        }

    }
}

