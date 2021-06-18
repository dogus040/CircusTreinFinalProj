using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTreinFinalProj_UnitTests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void checkDoesAnimalFitIntoWagonExpectedTrue()
        {
            // Arrange

            bool doesAnimalFit;

            Wagon wagon = new Wagon();

            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            wagon.addAnimalToWagon(H5); // wagon vullen voor vergelijking.
            doesAnimalFit = wagon.doesAnimalFitIntoWagon(H3);

            // Assert

            Assert.IsTrue(doesAnimalFit);  // animal die toegevoegd gaat worden
        }

        [TestMethod]
        public void checkDoesAnimalFitIntoWagonExpectedFalse()
        {
            // Arrange

            bool doesAnimalFit;

            Wagon wagon = new Wagon();

            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);
            Herbivore H1 = new Herbivore(AnimalSizeEnum.Large);

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);

            // Act

            wagon.addAnimalToWagon(H3);
            wagon.addAnimalToWagon(H5);
            wagon.addAnimalToWagon(H1);

            doesAnimalFit = wagon.doesAnimalFitIntoWagon(C3);

            // Assert

            Assert.IsFalse(doesAnimalFit); // animal die toegevoegd gaat worden
        }

        [TestMethod]
        public void checkDecreaseWagonCapacity()
        {
            // Arrange

            Wagon wagon = new Wagon();

            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);

            // Act

            wagon.decreaseWagonCapacity(H3);

            // Assert

            Assert.AreEqual(7, wagon.Capacity);
        }

        [TestMethod]
        public void checkAddAnimalToWagon()
        {
            // Arrange

            Wagon wagon = new Wagon();

            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);

            // Act

            wagon.addAnimalToWagon(H3);

            // Assert

            Assert.AreEqual(H3, wagon.Animals[0]);
        }
    }
}
