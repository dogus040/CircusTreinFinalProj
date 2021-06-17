using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTreinFinalProjTests
{
    [TestClass]
    public class HerbivoreTest
    {
        [TestMethod]
        public void checkEnumPassedToHerbivoreSize()
        {
            // Arrange

            Herbivore H1 = new Herbivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act


            // Assert

            Assert.AreEqual(AnimalSizeEnum.Small, H1.AnimalSize);
            Assert.AreEqual(AnimalSizeEnum.Medium, H3.AnimalSize);
            Assert.AreEqual(AnimalSizeEnum.Large, H5.AnimalSize);
        }

        [TestMethod]
        public void checkObjectReturnedWithHerbivoreNameAndSizeInt()
        {
            // Arrange

            Herbivore H1 = new Herbivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            // Assert

            Assert.AreEqual("H" + (int)AnimalSizeEnum.Small, H1.ToString());
            Assert.AreEqual("H" + (int)AnimalSizeEnum.Medium, H3.ToString());
            Assert.AreEqual("H" + (int)AnimalSizeEnum.Large, H5.ToString());
        }

        [TestMethod]
        public void checkifAnimalSafeMethodExpectTrue()
        {
            // Arrange

            Train train = new Train();

            Wagon wagon = new Wagon();

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            wagon.Animals.Add(C3); // een dier die zich in een wagon bevind

            // Assert

            Assert.AreEqual(true , H5.isAnimalSafe(wagon.Animals) /* het dier wat toegevoegd wordt. */);
        }

        [TestMethod]
        public void checkifAnimalSafeMethodExpectFalse()
        {
            // Arrange

            Train train = new Train();

            Wagon wagon = new Wagon();

            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);

            // Act

            wagon.Animals.Add(C5); // een dier die zich in een wagon bevind

            // Assert

            Assert.AreEqual(false, H3.isAnimalSafe(wagon.Animals));
        }
    }
}
