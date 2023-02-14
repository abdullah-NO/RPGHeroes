using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Weapon
{
    public class WeaponClass : Item
    {
        public int weaponDamage { get; set; }
        public WeaponClass(string weaponName,Weapons weapon) : base(weaponName)
        {
            setWeaponDamage(weapon);
        }
        private void setWeaponDamage(Weapons weapon)
        {
            switch (weapon)
            {
                case Weapons.Staff:
                    weaponDamage = 3;
                    break;
                case Weapons.Wand:
                    weaponDamage = 1;
                    break;
                case Weapons.Dagger:
                    weaponDamage = 2;
                    break;
                case Weapons.Bow:
                    weaponDamage = 2;
                    break;
                case Weapons.Sword:
                    weaponDamage = 5;
                    break;
                case Weapons.Axe:
                    weaponDamage = 7;
                    break;

            }
        }
    }
}
