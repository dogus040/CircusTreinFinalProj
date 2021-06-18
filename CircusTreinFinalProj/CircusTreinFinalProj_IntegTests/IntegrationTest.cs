using CircusTreinFinalProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTreinFinalProj_IntegTests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void OneC1TwoC3OneC5FiveH5ThreeH3TwoH1_ExpectSixWagons()
        {
            // Arrange

            Train train = new Train();

            List<Animal> animals = new List<Animal>()
                {
                    new Carnivore(AnimalSizeEnum.Small), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium),
                    new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Medium),new Herbivore(AnimalSizeEnum.Medium),
                    new Herbivore(AnimalSizeEnum.Small), new Herbivore(AnimalSizeEnum.Small)
                };


            // Act

            foreach (Animal animal in animals)
            {
                train.Animals.Add(animal);
            }


            train.spreadAnimals();

            // Assert

            Assert.AreEqual( 6 , train.Wagons.Count);
        }

        [TestMethod]

        public void ThreeC1TwoC3FourC5TwoH5FourH3FiveH1_ExpectTenWagons()
        {
            // Arrange

            Train train = new Train();

            List<Animal> animals = new List<Animal>()
                {
                    new Carnivore(AnimalSizeEnum.Small), new Carnivore(AnimalSizeEnum.Small), new Carnivore(AnimalSizeEnum.Small),
                    new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Large),
                    new Carnivore(AnimalSizeEnum.Large), new Carnivore(AnimalSizeEnum.Large), new Carnivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Medium),
                    new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Medium),
                    new Herbivore(AnimalSizeEnum.Small), new Herbivore(AnimalSizeEnum.Small), new Herbivore(AnimalSizeEnum.Small),
                    new Herbivore(AnimalSizeEnum.Small), new Herbivore(AnimalSizeEnum.Small)
                };


            // Act

            foreach (Animal animal in animals)
            {
                train.Animals.Add(animal);
            }


            train.spreadAnimals();

            // Assert

            Assert.AreEqual(10, train.Wagons.Count);
        }

        [TestMethod]

        public void OneC1FiveoC3OneC5FiveH5TwoH3TwoH1_ExpectEightWagons()
        {
            // Arrange

            Train train = new Train();

            List<Animal> animals = new List<Animal>()
                {
                    new Carnivore(AnimalSizeEnum.Small), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium),
                    new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium),
                    new Carnivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Small),
                    new Herbivore(AnimalSizeEnum.Small)
                };


            // Act

            foreach (Animal animal in animals)
            {
                train.Animals.Add(animal);
            }


            train.spreadAnimals();

            // Assert

            Assert.AreEqual(8, train.Wagons.Count);
        }
    }
}
