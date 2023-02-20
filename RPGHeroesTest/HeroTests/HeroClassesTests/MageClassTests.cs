using RPGHeroes.Hero;
using RPGHeroes.Hero.HeroClasses;

namespace RPGHeroesTest.HeroTests.HeroClassesTests
{
    public class MageClassTests
    {
        [Fact]
        public void ExpectCorrectNameOnMageObjectCreation()
        {
            // Arrange 
            string ExpectedmageName = "Abdullah the Mage";

            // Act
            MageClass mage = new MageClass("Abdullah the Mage");

            //Assert
            Assert.Equal(ExpectedmageName, mage.heroName);
        }

        [Fact]
        public void ExpectCorrectAttributeOnMageObjectCreation()
        {
            // Arrange 
            HeroAttribute ExpectedHeroAttributeOnMageCreation = new HeroAttribute(1, 1, 8);

            // Act
            MageClass mage = new MageClass("Abdullah the Mage");

            //Assert
            Assert.Equivalent(ExpectedHeroAttributeOnMageCreation, mage.levelAttributes);
        }

        [Fact]
        public void ExpectCorrectLevelOnMageObjectCreation()
        {
            // Arrange 
            int ExpectedmageLevel = 1;

            // Act
            MageClass mage = new MageClass("Abdullah the Mage");

            //Assert
            Assert.Equal(ExpectedmageLevel, mage.level);
        }

        [Fact]
        public void ExpectCorrectAttributesOnMageObjectLevelUp()
        {
            //Arrange
            HeroAttribute ExpectedAttributesAfterLevelUp = new HeroAttribute(2, 2, 13);
            MageClass mage = new("Abdullah the Mage");

            //Act
            mage.LevelUp();

            //Assert
            Assert.Equivalent(ExpectedAttributesAfterLevelUp, mage.levelAttributes);
        }


    }
}