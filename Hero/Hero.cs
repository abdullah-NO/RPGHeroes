using RPGHeroes.Item.Armor;
using RPGHeroes.Item.Weapon;
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
        public int equipment { get; set; }
        public List<int> validWeaponTypes { get; set; }
        public List<int> validArmorTypes { get; set; }
        
        public Hero(string heroName)
        {
            this.heroName = heroName;
            this.level = 1;
        }
        public abstract void LevelUp();
        public abstract void Equip(ArmorType armor);
        public abstract void Equip(Weapons weapon);
    }
}
