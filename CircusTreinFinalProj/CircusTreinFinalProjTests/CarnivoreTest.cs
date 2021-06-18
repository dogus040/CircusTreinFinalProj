using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTreinFinalProjTests
{
    [TestClass]
    public class CarnivoreTest
    {
        [TestMethod]
        public void checkEnumPassedToCarnivoreSize()
        {
            // Arrange

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);

            // Act


            // Assert

            Assert.AreEqual(AnimalSizeEnum.Small, C1.AnimalSize);
            Assert.AreEqual(AnimalSizeEnum.Medium, C3.AnimalSize);
            Assert.AreEqual(AnimalSizeEnum.Large, C5.AnimalSize);
        }

        [TestMethod]
        public void checkObjectReturnedWithCarnivoreNameAndSizeInt()
        {
            // Arrange

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);

            // Act

            // Assert

            Assert.AreEqual("C" + (int)AnimalSizeEnum.Small, C1.ToString());
            Assert.AreEqual("C" + (int)AnimalSizeEnum.Medium, C3.ToString());
            Assert.AreEqual("C" + (int)AnimalSizeEnum.Large, C5.ToString());
        }

        [TestMethod]
        public void checkifAnimalSafeMethodExpectTrue()
        {
            // Arrange

            Wagon wagon = new Wagon();

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            bool isSafe;

            // Act

            wagon.Animals.Add(H5); // een dier die zich in een wagon bevind
            isSafe = C3.isAnimalSafe(wagon.Animals);

            // Assert


            Assert.IsTrue(isSafe);
        }

        [TestMethod]
        public void checkifAnimalSafeMethodExpectFalse()
        {
            // Arrange

            Wagon wagon = new Wagon();

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Large);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);

            bool isSafe;

            // Act

            wagon.Animals.Add(C5); // een dier die zich in een wagon bevind
            isSafe = C3.isAnimalSafe(wagon.Animals);

            // Assert

            Assert.IsFalse(isSafe);
        }
    }
}
