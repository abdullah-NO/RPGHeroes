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
            Assert.Equivalent(ExpectedTotalAttribute,mage.TotalAttributes());
            
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
            Assert.Equivalent(ExpectedTotalAttribute, mage.TotalAttributes());

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
            Assert.Equivalent(ExpectedTotalAttribute, mage.TotalAttributes());
        }

        [Fact]
        public void ExpectCorrectTotalAttributesOnReplacedArmorEquipment()
        {
            //Arrange
            RogueClass rogue = new RogueClass("Abu - the rogue");
            HeroAttribute ExpectedTotalAttribute = new HeroAttribute(5, 14, 3);
            ArmorClass armorLeather = new ArmorClass(Armor.Leather, "BatmanSuit", slot.Body);
            ArmorClass armorMail = new ArmorClass(Armor.Mail, "You got Mail", slot.Body);
            rogue.Equip(armorLeather);
            rogue.LevelUp();

            //ACT
            rogue.Equip(armorMail);

            //Assert
            Assert.Equivalent(ExpectedTotalAttribute, rogue.TotalAttributes());
        }

        //Not Finished
        [Fact]
        public void ExpectCorrectTotalDamageOnNoEquipment()
        {
            //Arrange
            decimal ExpectedTotalDamage = 1.070M;
            HeroAttribute ExpectedAttribute = new(1, 7, 1);

            RogueClass rogue = new RogueClass("Abu - the rogue");

            //ACT 
            decimal totalDamage = rogue.HeroDamage(rogue.TotalAttributes());


            //Assert
            Assert.Equal(ExpectedTotalDamage, totalDamage);
        }

        
        [Fact]
        public void ExpectCorrectTotalDamageWithWeaponAndArmorEquipment()
        {
            //Arrange
            RogueClass rogue = new RogueClass("Abu - the rogue");
            HeroAttribute ExpectedTotalAttribute = new HeroAttribute(5, 14, 3);
            ArmorClass armorLeather = new ArmorClass(Armor.Leather, "BatmanSuit", slot.Body);
            ArmorClass armorMail = new ArmorClass(Armor.Mail, "You got Mail", slot.Body);
            rogue.Equip(armorLeather);
            rogue.LevelUp();

            //ACT
            rogue.Equip(armorMail);

            //Assert
            Assert.Equivalent(ExpectedTotalAttribute, rogue.TotalAttributes());
        }

        [Fact]
        public void ExpectCorrectInfoDisplayForHeroClassName()
        {

        }


        [Fact]
        public void ExpectCorrectInfoDisplayForHeroName()
        {

        }


        [Fact]
        public void ExpectCorrectInfoDisplayForHeroLevel()
        {

        }


        [Fact]
        public void ExpectCorrectInfoDisplayForHeroTotalStrength()
        {

        }


        [Fact]
        public void ExpectCorrectInfoDisplayForHeroTotalDexterity()
        {

        }

        [Fact]
        public void ExpectCorrectInfoDisplayForHeroTotalIntelligence()
        {

        }

        [Fact]
        public void ExpectCorrectInfoDisplayForHeroDamage()
        {

        }


    }
}
