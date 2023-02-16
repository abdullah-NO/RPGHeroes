using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;

namespace RPGHeroes.Hero.HeroClasses
{
    public class MageClass : Hero
    {
        public HeroAttribute mageAttribute;
        public MageClass(string mageName) : base(mageName)
        {
            HeroAttribute mageAttributesOnCreation = new(1, 1, 8);
            mageAttribute = mageAttributesOnCreation;
        }
        private void IncreaseMageAttributesLevelByLevelUp()
        {
            this.mageAttribute.strength += 1;
            this.mageAttribute.dexterity += 1;
            this.mageAttribute.intelligence += 5;
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
            get { return new List<Armor> { Armor.cloth}; }
        }
        
    }
}

