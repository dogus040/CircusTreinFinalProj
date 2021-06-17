using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTreinFinalProj_IntegTests
{
    [TestClass]
    public class divideAnimalsToCorrectWagonsTest
    {
        [TestMethod]
        public void divideAnimalsToCorrectWagonsWithoutConflicts()
        {
            Train currTrain = new Train();

            for (int i = 0; i < 3; i++)
            {
                currTrain.Animals.Add(new Carnivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Small });
                currTrain.Animals.Add(new Herbivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Small });
                currTrain.Animals.Add(new Carnivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Medium });
                currTrain.Animals.Add(new Herbivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Medium });
                currTrain.Animals.Add(new Carnivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Large });
                currTrain.Animals.Add(new Herbivore(new AnimalSizeEnum()) { AnimalSize = AnimalSizeEnum.Large });
            }

            currTrain.spreadAnimalsToWagons();

            Assert.AreEqual(18, currTrain.Animals.Count); // controlleer of de juiste hoeveelheid animals aan de begin lijst is toegevoegd.

        }
    }
}
