using RPGHeroes.Item.Armor;
using RPGHeroes.Item.Weapon;

namespace RPGHeroes.Hero.HeroClasses
{
    internal class MageClass : Hero
    {
        public HeroAttribute mageAttribute;
        public MageClass(string mageName) : base(mageName)
        {
            this.mageAttribute.strength = 1; 
            this.mageAttribute.dexterity = 1;
            this.mageAttribute.intelligence = 8;
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
            throw new NotImplementedException();
        }
       
    }
}
