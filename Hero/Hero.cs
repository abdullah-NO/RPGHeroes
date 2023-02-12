using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    internal class Hero
    {
        public string heroName { get; set; }
        public int level { get; set; }
        public int levelAttributes { get; set; }
        public int Equipment { get; set; }
        public List<int>[] validWeaponTypes { get; set; }
        public List<int>[] validArmorTypes { get; set; }
        
        public Hero(string heroName)
        {
            this.heroName = heroName;
        }
    }
}
