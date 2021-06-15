using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTreinFinalProjTests
{
    [TestClass]
    public class AnimalCombinationTests
    {
        [TestMethod]
        public void check_That_Carnivores_Can_Be_Added_To_Wagon_With_Larger_Herbivores()
        {
            // Arrange

            Train train = new Train();

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            train.spreadAnimals();

            // Assert

            Assert.AreEqual(1, train.Wagons.Count);
        }

        [TestMethod]
        public void check_That_Carnivores_Cant_Be_In_Same_Wagon()
        {
            // Arrange

            Train train = new Train();

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);

            // Act

            train.Animals.Add(C1);
            train.Animals.Add(C3);
            train.Animals.Add(C5);

            train.spreadAnimals();

            //  Assert

            Assert.AreEqual(3, train.Wagons.Count);
        }

        [TestMethod]
        public void check_For_Large_Herbivore_And_Medium_Carnivore_Are_In_Same_Wagon()
        {
            // Arrange

            Train train = new Train();

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            train.Animals.Add(C3);
            train.Animals.Add(H5);

            train.spreadAnimals();

            // Assert

            Assert.AreEqual(1, train.Wagons.Count);
        }

        [TestMethod]
        public void check_For_Large_Herbivore_With_Medium_Carnivore_And_Small_Carnivore()
        {
            // Arrange

            Train train = new Train();

            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // Act

            train.Animals.Add(C1);
            train.Animals.Add(C3);
            train.Animals.Add(H5);

            train.spreadAnimals();

            // Assert

            Assert.AreEqual(2, train.Wagons.Count);
        }
        [TestMethod]
        public void check_For_Small_Herbivore_And_Small_Carnivore()
        {
            // Arrange

            Train train = new Train();

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore H1 = new Herbivore(AnimalSizeEnum.Small);

            // Act

            train.Animals.Add(C1);
            train.Animals.Add(H1);

            train.spreadAnimals();

            // Assert

            Assert.AreEqual(2, train.Wagons.Count);
        }
    }
}
