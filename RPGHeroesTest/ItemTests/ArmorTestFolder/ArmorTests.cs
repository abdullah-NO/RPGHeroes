using RPGHeroes.Hero;
using RPGHeroes.Items;
using RPGHeroes.Items.Armor;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.ItemTests.ArmorTestFolder
{
    public class ArmorTests
    {
        [Fact]
        public void ExpectCorrectArmorNameOnArmorObjectCreation()
        {
            //Arrange
            string ExpectedArmorName = "The cloth of the Beggar";

            //Act
            ArmorClass armor = new ArmorClass(Armor.Cloth, "The cloth of the Beggar", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorName, armor.itemName);
        }

        [Fact]
        public void ExpectCorrectArmorTypeOnArmorClothObjectCreation()
        {
            //Arrange
            Armor ExpectedArmorType = Armor.Cloth;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Cloth, "The cloth of the Beggar", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorType, armor.armorType);
        }

        [Fact]
        public void ExpectCorrectArmorTypeOnArmorMailObjectCreation()
        {
            //Arrange
            Armor ExpectedArmorType = Armor.Mail;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Mail, "The mail of the Average guy", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorType, armor.armorType);
        }

        [Fact]
        public void ExpectCorrectArmorTypeOnArmorPlateObjectCreation()
        {
            //Arrange
            Armor ExpectedArmorType = Armor.Plate;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "The Plate of the Aristocrat", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorType, armor.armorType);
        }

        [Fact]
        public void ExpectCorrectArmorTypeOnArmorLeatherObjectCreation()
        {
            //Arrange
            Armor ExpectedArmorType = Armor.Leather;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Leather, "The Leather of the emo kid", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorType, armor.armorType);
        }

        [Fact]
        public void ExpectCorrectArmorTypeRequiredLevelOnLeatherArmorObjectCreation()
        {
            //Arrange
            int ExpectedRequiredLevel = 1;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Leather, "The Leather of the emo kid", slot.Body);

            //Assert
            Assert.Equal(ExpectedRequiredLevel, armor.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectArmorTypeRequiredLevelOnClothArmorObjectCreation()
        {
            //Arrange
            int ExpectedRequiredLevel = 1;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Cloth, "The cloth of the Beggar", slot.Body);

            //Assert
            Assert.Equal(ExpectedRequiredLevel, armor.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectArmorTypeRequiredLevelOnMailArmorObjectCreation()
        {
            //Arrange
            int ExpectedRequiredLevel = 2;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Mail, "The Mail of the Average guy", slot.Body);

            //Assert
            Assert.Equal(ExpectedRequiredLevel, armor.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectArmorTypeRequiredLevelOnPlateArmorObjectCreation()
        {
            //Arrange
            int ExpectedRequiredLevel = 3;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "The Plate of the Aristocrat", slot.Body);

            //Assert
            Assert.Equal(ExpectedRequiredLevel, armor.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectArmorBodySlotArmorObjectCreation()
        {
            //Arrange
            slot ExpectedArmorSlot = slot.Body;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "The Plate of the Aristocrat", slot.Body);

            //Assert
            Assert.Equal(ExpectedArmorSlot, armor.itemSlot);
        }

        [Fact]
        public void ExpectCorrectArmorLegsSlotArmorObjectCreation()
        {
            //Arrange
            slot ExpectedArmorSlot = slot.Legs;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "The Plate of the Aristocrat", slot.Legs);

            //Assert
            Assert.Equal(ExpectedArmorSlot, armor.itemSlot);
        }

        [Fact]
        public void ExpectCorrectArmorHeadSlotArmorObjectCreation()
        {
            //Arrange
            slot ExpectedArmorSlot = slot.Head;

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "The Plate of the Aristocrat", slot.Head);

            //Assert
            Assert.Equal(ExpectedArmorSlot, armor.itemSlot);
        }

        [Fact]
        public void ExpectCorrectArmorAttributeOnArmorClothObjectCreation()
        {
            //Arrange
            HeroAttribute ExpectedArmorAttributeBasedOnType = new HeroAttribute(1,3,3);

            //Act
            ArmorClass armor = new ArmorClass(Armor.Cloth, "The cloth of the beggar", slot.Head);

            //Assert
            Assert.Equivalent(ExpectedArmorAttributeBasedOnType, armor.armorAttribute);
        }

        [Fact]
        public void ExpectCorrectArmorAttributeOnArmorLeatherObjectCreation()
        {
            //Arrange
            HeroAttribute ExpectedArmorAttributeBasedOnType = new HeroAttribute(2, 2, 1);

            //Act
            ArmorClass armor = new ArmorClass(Armor.Leather, "LeatherStuffz", slot.Head);

            //Assert
            Assert.Equivalent(ExpectedArmorAttributeBasedOnType, armor.armorAttribute);
        }

        [Fact]
        public void ExpectCorrectArmorAttributeOnArmorMailObjectCreation()
        {
            //Arrange
            HeroAttribute ExpectedArmorAttributeBasedOnType = new HeroAttribute(3,2, 1);

            //Act
            ArmorClass armor = new ArmorClass(Armor.Mail, "MailStuffz", slot.Head);

            //Assert
            Assert.Equivalent(ExpectedArmorAttributeBasedOnType, armor.armorAttribute);
        }

        [Fact]
        public void ExpectCorrectArmorAttributeOnArmorPlateObjectCreation()
        {
            //Arrange
            HeroAttribute ExpectedArmorAttributeBasedOnType = new HeroAttribute(4, 1, 1);

            //Act
            ArmorClass armor = new ArmorClass(Armor.Plate, "PlateStuffz", slot.Head);

            //Assert
            Assert.Equivalent(ExpectedArmorAttributeBasedOnType, armor.armorAttribute);
        }
    }
}
