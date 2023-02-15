using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items.Weapon
{
    public class WeaponClass : Item
    {
        public int weaponDamage { get; set; }
        public WeaponClass(Weapons weapon, string weaponName) : base(weaponName)
        {
                SetWeaponDamageAndRequiredLevel(weapon);
                heroSlot = slot.WeaponSlot;
        }
        private void SetWeaponDamageAndRequiredLevel(Weapons weapon)
        {
            switch (weapon)
            {
                case Weapons.Staff:
                    this.weaponDamage = 3;
                    requiredLevel = 3;
                    break;
                case Weapons.Wand:
                    this.weaponDamage = 1;
                    requiredLevel = 1;
                    break;
                case Weapons.Dagger:
                    this.weaponDamage = 2;
                    requiredLevel = 1;
                    break;
                case Weapons.Bow:
                    this.weaponDamage = 2;
                    requiredLevel = 1;
                    break;
                case Weapons.Sword:
                    this.weaponDamage = 5;
                    requiredLevel = 1;
                    break;
                case Weapons.Axe:
                    this.weaponDamage = 7;
                    requiredLevel = 3;
                    break;
                case Weapons.Hammer:
                    this.weaponDamage = 6;
                    requiredLevel = 2;
                    break;
            }
        }
    }
}
