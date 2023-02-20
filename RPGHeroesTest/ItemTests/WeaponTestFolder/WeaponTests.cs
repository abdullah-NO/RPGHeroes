using RPGHeroes.Items;
using RPGHeroes.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTest.ItemTests.WeaponTestFolder
{
    public class WeaponTests
    {
        [Fact]
        public void ExpectCorrectWeaponNameOnWeaponObjectCreation()
        {
            //Arrange
            string ExpectedweaponName = "boring weapon";

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponName, weapon.itemName);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeAxeOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Axe;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeHammerOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Hammer;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Hammer, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeSwordOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Sword;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Sword, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeBowOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Bow;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Bow, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeDaggerOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Dagger;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Dagger, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeWandOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Wand;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Wand, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeStaffOnWeaponObjectCreation()
        {
            //Arrange
            Weapons ExpectedWeapon = Weapons.Staff;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Staff, "boring weapon");

            //Assert
            Assert.Equal(ExpectedWeapon, weapon.weaponType);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnStaffWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 3;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Staff, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnWandWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 1;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Wand, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnDaggerWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 1;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Dagger, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnBowWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 1;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Bow, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnSwordWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 1;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Sword, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnHammerWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 2;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Hammer, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponTypeLevelOnAxeWeaponObjectCreation()
        {
            //Arrange
            int ExpectedRequiredWeaponTypeLevel = 3;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "boring weapon");

            //Assert
            Assert.Equal(ExpectedRequiredWeaponTypeLevel, weapon.requiredLevel);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponStaffObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Staff, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponAxeObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponDaggerObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Dagger, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponBowObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Bow, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponSwordObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Sword, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponHammerObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Hammer, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponSlotOnWeaponWandObjectCreation()
        {
            //Arrange
            slot ExpectedSlot = slot.WeaponSlot;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Wand, "boring weapon");

            //Assert
            Assert.Equal(ExpectedSlot, weapon.itemSlot);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponStaffObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 3;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Staff, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponWandObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 1;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Wand, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponBowObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 2;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Bow, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponDaggerObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 2;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Dagger, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponAxeObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 7;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Axe, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponHammerObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 6;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Hammer, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

        [Fact]
        public void ExpectCorrectWeaponDamageOnWeaponSwordObjectCreation()
        {
            //Arrange
            int ExpectedweaponDamage = 5;

            //Act
            WeaponClass weapon = new WeaponClass(Weapons.Sword, "boring weapon");

            //Assert
            Assert.Equal(ExpectedweaponDamage, weapon.weaponDamage);
        }

    }
}
