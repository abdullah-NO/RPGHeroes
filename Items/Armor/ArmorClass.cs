using RPGHeroes.Hero.HeroClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items.Armor
{
    public class ArmorClass : Item
    {
        public Armor armor { get; set; }
        public HeroAttribute armorAttribute { get; set; }
        public ArmorClass(Armor armor , string armorName, slot armorSlot) : base(armorName,armorSlot)
        {
               this.armor = armor;
               this.armorAttribute = new HeroAttribute();
               SetArmorAttributesAndRequiredLevel(armor); 
               Console.WriteLine("not valid armor name");
        }
        private void SetArmorAttributesAndRequiredLevel(Armor armor)
        {

            switch (armor)
            {
                case Armor.Leather:
                    this.armorAttribute.dexterity = 2;
                    this.armorAttribute.strength = 2;
                    this.armorAttribute.intelligence = 1;
                    requiredLevel = 1;
                    break;
                case Armor.Plate:
                    this.armorAttribute.dexterity = 1;
                    this.armorAttribute.strength = 4;
                    this.armorAttribute.intelligence = 1;
                    requiredLevel = 3;
                    break;
                case Armor.Chainmail:
                    this.armorAttribute.dexterity = 2;
                    this.armorAttribute.strength = 2;
                    this.armorAttribute.intelligence = 1;
                    requiredLevel = 2;
                    break;
                case Armor.cloth:
                    this.armorAttribute.dexterity = 3;
                    this.armorAttribute.strength = 1;
                    this.armorAttribute.intelligence= 3;
                    requiredLevel = 1;
                    break;
            }
        }
    }
}
