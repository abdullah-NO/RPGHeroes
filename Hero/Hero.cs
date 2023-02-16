using RPGHeroes.Items;
using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
     public abstract class Hero
    {
        public string heroName { get; set; }
        public int level { get; set; }
        public int levelAttributes { get; set; }
        public Dictionary<slot, Item?> equipment { get; set; }
        public virtual List<Weapons> validWeaponTypes { get; set; }
        public  virtual List<Armor> validArmorTypes { get; set; }
        
        public Hero(string heroName)
        {
            this.heroName = heroName;
            equipment= new Dictionary<slot, Item?>();
            this.level = 1;
        }
        public abstract void LevelUp();
        public void Equip(ArmorClass armorObject)
        {

           if(armorObject.itemSlot != slot.WeaponSlot)
            {
                if (IsValidArmorType(armorObject))
                {
                    
                    equipment.Add(armorObject.itemSlot, armorObject);
                }
            }

        }
        public void Equip(WeaponClass weaponObject, slot weapon)
        {
            if (weapon == slot.WeaponSlot)
            {
                if (IsValidWeaponType(weaponObject))
                {
                    equipment.Add(weapon, weaponObject);
                }
            }
        }
        public bool IsValidArmorType(ArmorClass armorObject)
        {
            return validArmorTypes.Contains(armorObject.armor);
        }
        public bool IsValidWeaponType(WeaponClass weaponObject)
        {
            return validWeaponTypes.Contains(weaponObject.weapon);
        }
    }
}
