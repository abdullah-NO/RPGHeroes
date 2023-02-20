using RPGHeroes.Hero;
using RPGHeroes.Hero.HeroClasses;
using RPGHeroes.Items;
using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
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

        [Fact]
        public void ExpectCorrectExceptionThrownOnInvalidWeaponEquipment()
        {
            //Arrange
            MageClass mage = new MageClass("Abu - the mage");
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "Axe of cripling dept");

            //Act + Assert
            Exception ex = Assert.Throws<EquipItemException>(() => mage.Equip(weapon));
        }


        [Fact]
        
        public void ExpectCorrectTotalAttributesOnNoEquipment()
        {
            //Arrange
            MageClass mage = new MageClass("Abu - the mage");
            HeroAttribute ExpectedTotalAttribute = new HeroAttribute(1,1,8);

            //ACT + Assert
            Assert.Equivalent(ExpectedTotalAttribute,mage.TotalAttributes(mage.CalculateSumOfEquipmentAttributes(), mage.levelAttributes));
            
        }

        [Fact]

        public void ExpectCorrectTotalAttributesOnOneArmorEquipment()
        {
            //Arrange
            MageClass mage = new MageClass("Abu - the mage");
            HeroAttribute ExpectedTotalAttribute = new HeroAttribute(2, 4, 11);
            ArmorClass armor = new ArmorClass(Armor.Cloth, "Cloth of the beggar", slot.Body);

            //ACT + Assert
            mage.Equip(armor);

            //Assert
            Assert.Equivalent(ExpectedTotalAttribute, mage.TotalAttributes(mage.CalculateSumOfEquipmentAttributes(), mage.levelAttributes));

        }

        [Fact]
        public void ExpectCorrectTotalAttributesOnTwoArmorEquipment()
        {
            //Arrange
            MageClass mage = new MageClass("Abu - the mage");
            HeroAttribute ExpectedTotalAttribute = new HeroAttribute(3, 7, 14);
            ArmorClass armorCloth = new ArmorClass(Armor.Cloth, "Cloth of the beggar", slot.Body);
            ArmorClass armorCloth2 = new ArmorClass(Armor.Cloth,"Cloth of shameful headcover",slot.Head);
            

            //ACT
            mage.Equip(armorCloth);
            mage.Equip(armorCloth2);

            //Assert
            Assert.Equivalent(ExpectedTotalAttribute, mage.TotalAttributes(mage.CalculateSumOfEquipmentAttributes(), mage.levelAttributes));

        }
    }
}
