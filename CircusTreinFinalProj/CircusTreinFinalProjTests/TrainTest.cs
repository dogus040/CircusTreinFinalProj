using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTreinFinalProj_UnitTests
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void checkSpreadAnimalsToWagons()
        {
            // Arrange

            Train train = new Train();

            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);
            Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);
            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);

            

            // Act

            train.Animals.Add(H3);
            train.Animals.Add(H5);
            train.Animals.Add(C5);
            train.Animals.Add(C1); // lijst van animals in de trein, zonder wagon, dit zijn alle animals die je wilt verdelen.


            train.spreadAnimalsToWagons();
            
            // Assert

            Assert.AreEqual(H3 , train.Wagons[0].Animals[0]); // check of object zich in de lijst van animals bevind van de wagon
            Assert.AreEqual(H5 , train.Wagons[0].Animals[1]);
            Assert.AreEqual(C5, train.Wagons[1].Animals[0]); // Carnivore wordt in een aparte wagon gegooid vanwege isAnimalSafe && DoesAnimalFitIntoWagon check.
            Assert.AreEqual(C1, train.Wagons[0].Animals[2]);
        }

        [TestMethod]
        public void checkSearchForWagonExpectSameWagon() // hier wordt de if gechecked van searchForWagon method
        {
            // Arrange

            Train train = new Train();

            Wagon wagon2 = new Wagon(); // de eerste wagon wordt automatisch aangemaakt bij het instancieren van de train class
            // deze wordt gebruikt om carnivores mee te vullen, zo check je dat een herbivore niet in een carnivoor wagon wordt gegooid.


            // deze bevinden zich in de eerste wagon
            Herbivore H1 = new Herbivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            // deze bevinden zich in de tweede wagon
            Carnivore w2_C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore w2_H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore w2_H5 = new Herbivore(AnimalSizeEnum.Large);

            Herbivore addedAnimal_H1 = new Herbivore(AnimalSizeEnum.Small); // deze herbivore wordt gebruikt in de method om te checken of die bij een van de wagons past.
            // Act
            train.SearchForWagon(H1);

            // Assert

            Assert.AreEqual(false, doesAnimalFit); // animal die toegevoegd gaat worden
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
