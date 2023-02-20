using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    public abstract class Item
    {
        
        public string itemName { get; set; }
        public int requiredLevel { get; set; }
        public slot itemSlot { get; set; }

        public Item(string itemName, slot itemSlot)
        {
            this.itemName = itemName;
            this.itemSlot = itemSlot;
        }
        public Item(string itemName)
        {
            this.itemName = itemName;
        }
    }
}
