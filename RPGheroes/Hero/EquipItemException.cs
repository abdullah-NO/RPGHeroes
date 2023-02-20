using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    public class EquipItemException : Exception
    {
        public EquipItemException()
        {
        }

        public EquipItemException(string message)
            : base(message)
        {

        }

        public EquipItemException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
