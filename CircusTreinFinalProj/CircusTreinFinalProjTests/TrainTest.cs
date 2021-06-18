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


            train.spreadAnimals();
            
            // Assert

            Assert.AreEqual(H3 , train.Wagons[0].Animals[0]); // check of herbivore zich in de lijst van animals bevind van de wagon
            Assert.AreEqual(H5 , train.Wagons[0].Animals[1]);
            Assert.AreEqual(C5, train.Wagons[1].Animals[0]); // carnivore wordt in een aparte wagon gegooid vanwege isAnimalSafe && DoesAnimalFitIntoWagon check.
            Assert.AreEqual(C1, train.Wagons[0].Animals[2]);
        }

        [TestMethod]
        public void checkSearchForWagonExpectSameWagon() // return een wagon waar de animal in past
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

            train.Wagons[0].addAnimalToWagon(H1); // wagon met herbivores
            train.Wagons[0].addAnimalToWagon(H3);
            train.Wagons[0].addAnimalToWagon(H5);

            train.Wagons.Add(wagon2); // wagon aan lijst van wagons toevoegen voor Assert vergelijking.

            train.Wagons[1].addAnimalToWagon(w2_C1); //deze wagon kan nooit gereturned worden omdat herbivore hier conflicten heeft.
            train.Wagons[1].addAnimalToWagon(w2_H3);
            train.Wagons[1].addAnimalToWagon(w2_H5);

            // Assert

            Assert.AreEqual(train.Wagons[0], train.SearchForWagon(addedAnimal_H1)); // check of wagon die wordt gereturned een wagon is die niet vol is en of isAnimalSafe true is.
            Assert.AreNotEqual(train.Wagons[1], train.SearchForWagon(addedAnimal_H1)); // check dat wagon met carnivoren niet wordt gereturned.
        }

        [TestMethod]
        public void checkSearchForWagonExpectNewWagon() // return een nieuwe aangemaakte wagon.
        {
            // Arrange

            Train train = new Train(); //

            //je ziet dat er geen wagon wordt aangemaakt omdat bij het instancieren van Train class automatisch een wagon wordt aangemaakt

            // deze bevinden zich in de eerste wagon
            Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);
            Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
            Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);

            Herbivore addedAnimal_H1 = new Herbivore(AnimalSizeEnum.Small); // deze herbivore wordt gebruikt in de method om te checken of die bij een van de wagons past.

            // Act

            train.Wagons[0].addAnimalToWagon(C1); //deze wagon kan nooit gereturned worden omdat herbivore hier conflicten heeft.
            train.Wagons[0].addAnimalToWagon(H3);
            train.Wagons[0].addAnimalToWagon(H3);

            // Assert

            train.SearchForWagon(addedAnimal_H1);  

            Assert.AreEqual(train.Wagons[1], train.SearchForWagon(addedAnimal_H1)); // return een nieuw aangemaakte wagon die leeg is.
        }
    }
}
