using RPGHeroes.Hero;
using RPGHeroes.Hero.HeroClasses;
using RPGHeroes.Items;
using RPGHeroes.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.HeroTests
{
    public class HeroTests
    {
        [Fact]
        public void ExpectCorrectExceptionThrownOnInvalidArmorEquipment()
        {
            //Arrange
            MageClass mage = new MageClass("Abu - the mage");
            ArmorClass armor = new ArmorClass(Armor.Mail, "poor mans mail", slot.Body);


            //Act + Assert
            Exception ex = Assert.Throws<EquipItemException>(() => mage.Equip(armor));

        }
    }
}
