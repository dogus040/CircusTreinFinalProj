using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTreinFinalProjTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkAmountOfWagonsCreated()
        {
            Train train = new Train();

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            train.spreadAnimals();

            Assert.AreEqual(1, train.Wagons.Count);
        }

        [TestMethod]
        public void checkIfWagonsAreSeperate()
        {
            Train train = new Train();

            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);

            train.spreadAnimals();

            Assert.AreEqual(3, train.Wagons.Count);
        }
    }
}
