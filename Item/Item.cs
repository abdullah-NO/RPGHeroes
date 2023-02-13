using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item
{
    public abstract class Item
    {
        public string itemName { get; set; }
        public int requiredLevel { get; set; }
        public slot heroSlot { get; set; }

        public Item(string itemName, int requiredLevel, slot heroSlot)
        {
            this.itemName = itemName;
            this.requiredLevel = requiredLevel;
            this.heroSlot = heroSlot;
        }
    }
}
