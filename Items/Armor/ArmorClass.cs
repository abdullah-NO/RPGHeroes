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
        public ArmorClass(Armor armor , string armorName) : base(armorName)
        {
               this.armor = armor;
               SetArmorAttributesAndRequiredLevel(armor); 
               Console.WriteLine("not valid armor name");
        }
        private void SetArmorAttributesAndRequiredLevel(Armor armor)
        {

            switch (armor)
            {
                case Armor.Leather:
                    requiredLevel = 1;
                    break;
                case Armor.Plate:
                    requiredLevel = 3;
                    break;
                case Armor.Chainmail:
                    requiredLevel = 2;
                    break;
                case Armor.cloth:
                    requiredLevel = 1;
                    break;
            }
        }
    }
}
