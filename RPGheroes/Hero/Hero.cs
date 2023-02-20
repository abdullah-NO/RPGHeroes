using RPGHeroes.Hero.HeroClasses;
using RPGHeroes.Items;
using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace RPGHeroes.Hero
{
    public abstract class Hero
    {
        public string heroName { get; set; }
        public int level { get; set; }
        public HeroAttribute levelAttributes { get; set; }
        public Dictionary<slot, Item?> equipment { get; set; }
        public abstract string ClassName { get; }
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
                if (IsValidArmorType(armorObject, level))
                {
                    if (equipment.TryGetValue(armorObject.itemSlot, out var currentItem) && currentItem != null)
                    {
                        equipment[armorObject.itemSlot] = armorObject;
                    }
                    else
                    {
                        equipment.Add(armorObject.itemSlot, armorObject);
                    }
                }

            }

        }
        public void Equip(WeaponClass weaponObject)
        {
            if(!IsValidWeaponType(weaponObject,level))
            {
                equipment[weaponObject.itemSlot] = weaponObject;
                
            }
            else 
            {
               
            }
        }
        public bool IsValidArmorType(ArmorClass armorObject,int heroLevel)
        {
            if (heroLevel < armorObject.requiredLevel || !validArmorTypes.Contains(armorObject.armorType))
            {
                throw new EquipItemException($"The armor is not available for {this.ClassName} or the required level for the armor is too high");
            }
            return true;
        }
        public bool IsValidWeaponType(WeaponClass weaponObject, int heroLevel)
        {
            if (heroLevel < weaponObject.requiredLevel || !validWeaponTypes.Contains(weaponObject.weaponType))
            {
                throw new EquipItemException($"the weapon is not available for {ClassName} or the required level for the weapon is to high");
            }
            else
                return true;
        }
        public HeroAttribute CalculateSumOfEquipmentAttributes()
        {
            HeroAttribute totalEquipmentAttributes = new HeroAttribute();
            foreach (var keyValuePair in equipment) 
            {
                if(keyValuePair.Key != slot.WeaponSlot)
                {
                    ArmorClass? armor = keyValuePair.Value as ArmorClass;
                    if (armor == null)
                    {
                        totalEquipmentAttributes.dexterity += 0;
                        totalEquipmentAttributes.strength += 0;
                        totalEquipmentAttributes.intelligence += 0;
                    }
                    else
                    {
                        totalEquipmentAttributes.addHeroAttributes(armor.armorAttribute);
                    }
                }
            }
            return totalEquipmentAttributes;
        }
        public HeroAttribute TotalAttributes(HeroAttribute totalEquipmentAttribute, HeroAttribute AttributeOfHero)
        {
            HeroAttribute? sumOfTotalHeroAttributes = null;
            sumOfTotalHeroAttributes = AttributeOfHero.addHeroAttributes(totalEquipmentAttribute);
            HeroDamage(sumOfTotalHeroAttributes, equipment);
            return sumOfTotalHeroAttributes;
        }
        public double HeroDamage(HeroAttribute totalAttributes, Dictionary<slot, Item?> equipment)
        {
            int unequipped = 1;
            if (this is MageClass)
            {
                if (equipment.TryGetValue(slot.WeaponSlot, out var item) && item is WeaponClass weapon)
                {
                    return weapon.weaponDamage * (1+ (totalAttributes.intelligence/100));
                }
                else 
                {
                    return (unequipped * (totalAttributes.intelligence / 100));
                }
            }
            if (this is RangerClass)
            {
                if (equipment.TryGetValue(slot.WeaponSlot, out var item) && item is WeaponClass weapon)
                {
                    return (weapon.weaponDamage * (1 + (totalAttributes.intelligence / 100)));
                }
                else
                {
                    return (unequipped * (totalAttributes.intelligence / 100));
                }
            }
            else if (this is RogueClass)
            {
                if (equipment.TryGetValue(slot.WeaponSlot, out var item) && item is WeaponClass weapon)
                {
                    return (weapon.weaponDamage * (1 + (totalAttributes.intelligence / 100)));
                }
                else
                {
                    return (unequipped * (totalAttributes.intelligence / 100));
                }
            }
            else if (this is WarriorClass)
            {
                if (equipment.TryGetValue(slot.WeaponSlot, out var item) && item is WeaponClass weapon)
                {
                    return (weapon.weaponDamage * (1 + (totalAttributes.intelligence / 100)));
                }
                else
                {
                    return (unequipped * (totalAttributes.intelligence / 100));
                }
            }
            return 0;
        }
        public string DisplayHeroStats()
        {
            HeroAttribute totalAttributes = TotalAttributes(CalculateSumOfEquipmentAttributes(), levelAttributes);
            double totalHeroDamage = HeroDamage(TotalAttributes(CalculateSumOfEquipmentAttributes(), levelAttributes), equipment);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {heroName}");
            sb.AppendLine($"Class: {ClassName}"); 
            sb.AppendLine($"Level: {level}");
            sb.AppendLine($"Total Strength: {totalAttributes.strength}");
            sb.AppendLine($"Total Dexterity: {totalAttributes.dexterity}");
            sb.AppendLine($"Total Intelligence: {totalAttributes.intelligence}");
            sb.AppendLine($"Damage: {totalHeroDamage}");
            return sb.ToString();
        }
    }
}
