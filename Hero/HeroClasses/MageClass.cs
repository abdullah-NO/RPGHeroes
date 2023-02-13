using RPGHeroes.Item.Armor;
using RPGHeroes.Item.Weapon;

namespace RPGHeroes.Hero.HeroClasses
{
    internal class MageClass : Hero
    {
        public HeroAttribute mageAttribute = new();
        public MageClass(string mageName) : base(mageName)
        {
            
            mageAttribute.strength = 1; 
            mageAttribute.dexterity = 1;
            mageAttribute.intelligence = 8;
        }
        private void IncreaseMageAttributesLevelByLevelUp()
        {
            mageAttribute.strength += 1;
            mageAttribute.dexterity += 1;
            mageAttribute.intelligence += 5;
        }
        public override void LevelUp()
        {
            level++;
            IncreaseMageAttributesLevelByLevelUp();
            throw new NotImplementedException();
        }
        public override void Equip(ArmorType chosenArmor)
        {
            if (chosenArmor == ArmorType.cloth)
            {

            }
            throw new NotImplementedException();
        }
        public override void Equip(Weapons chosenWeapon)
        {
            if (chosenWeapon == Weapons.Staff || chosenWeapon == Weapons.Wand)
            {

            }
            throw new NotImplementedException();
        }
    }
}
