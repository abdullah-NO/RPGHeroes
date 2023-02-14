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

        public Item()
        {

        }
        public Item(string itemName, slot heroSlot)
        {
            this.itemName = itemName;
            this.requiredLevel = requiredLevel;
            this.heroSlot = heroSlot;
        }
        public Item(string itemName)
        {
            this.itemName = itemName;
            this.requiredLevel = requiredLevel;
            this.heroSlot = heroSlot;
        }


    }
}
