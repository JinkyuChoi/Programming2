using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2;

namespace UnitTestAssignment2
{ 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateWildCat()
        {
            Cat cat = new Cat();

            Assert.AreEqual("Cat", cat.Name);
            Assert.AreEqual(Location.Wild, cat.Location);
            Assert.AreEqual(4, cat.LegCount());
            Assert.AreEqual(true, cat.IsWild());
            Assert.AreEqual("Meow",cat.MakeSound());
        }
        [TestMethod]
        public void CreateZooCat()
        {
            Cat cat = new Cat();
            Zoo zoo = new Zoo();

            zoo.AddAnimal(cat);

            Assert.AreEqual("Cat", cat.Name);
            Assert.AreEqual(Location.Zoo, cat.Location);
            Assert.AreEqual(4, cat.LegCount());
            Assert.AreEqual(false, cat.IsWild());
            Assert.AreEqual(true, zoo.AddAnimal(cat));
            Assert.AreEqual("Meow", cat.MakeSound());
        }
        [TestMethod]
        public void CreateHouseCat()
        {
            Cat cat = new Cat();
            House house = new House();

            house.AddAnimal(cat);

            Assert.AreEqual("Cat", cat.Name);
            Assert.AreEqual(Location.House, cat.Location);
            Assert.AreEqual(4, cat.LegCount());
            Assert.AreEqual(false, cat.IsWild());
            Assert.AreEqual(true, house.AddAnimal(cat));
            Assert.AreEqual("Meow", cat.MakeSound());
        }
        [TestMethod]
        public void CreateWildTiger()
        {
            Tiger tiger = new Tiger();

            Assert.AreEqual("Tiger", tiger.Name);
            Assert.AreEqual(Location.Wild, tiger.Location);
            Assert.AreEqual(4, tiger.LegCount());
            Assert.AreEqual(true, tiger.IsWild());
            Assert.AreEqual("Roar", tiger.MakeSound());
        }
        [TestMethod]
        public void CreateZooTiger()
        {
            Tiger tiger = new Tiger();
            Zoo zoo = new Zoo();

            zoo.AddAnimal(tiger);

            Assert.AreEqual("Tiger", tiger.Name);
            Assert.AreEqual(Location.Zoo, tiger.Location);
            Assert.AreEqual(4, tiger.LegCount());
            Assert.AreEqual(false, tiger.IsWild());
            Assert.AreEqual(true, zoo.AddAnimal(tiger));
            Assert.AreEqual("Roar", tiger.MakeSound());
        }
        [TestMethod]
        public void CreateHouseTiger()
        {
            Tiger tiger = new Tiger();
            House house = new House();

            house.AddAnimal(tiger);

            Assert.AreEqual("Tiger", tiger.Name);
            Assert.AreEqual(Location.House, tiger.Location);
            Assert.AreEqual(4, tiger.LegCount());
            Assert.AreEqual(false, tiger.IsWild());
            Assert.AreEqual(true, house.AddAnimal(tiger));
            Assert.AreEqual("Roar", tiger.MakeSound());
        }
        [TestMethod]
        public void CreateWildPenguin()
        {
            Penguin penguin = new Penguin();

            Assert.AreEqual("Penguin", penguin.Name);
            Assert.AreEqual(Location.Wild, penguin.Location);
            Assert.AreEqual(2, penguin.LegCount());
            Assert.AreEqual(true, penguin.IsWild());
            Assert.AreEqual("Honk", penguin.MakeSound());
        }
        [TestMethod]
        public void CreateZooPenguin()
        {
            Penguin penguin = new Penguin();
            Zoo zoo = new Zoo();

            zoo.AddAnimal(penguin);

            Assert.AreEqual("Penguin", penguin.Name);
            Assert.AreEqual(Location.Zoo, penguin.Location);
            Assert.AreEqual(2, penguin.LegCount());
            Assert.AreEqual(false, penguin.IsWild());
            Assert.AreEqual(true, zoo.AddAnimal(penguin));
            Assert.AreEqual("Honk", penguin.MakeSound());
        }
        [TestMethod]
        public void CreateHousePenguin()
        {
            Penguin penguin = new Penguin();
            House house = new House();

            house.AddAnimal(penguin);

            Assert.AreEqual("Penguin", penguin.Name);
            Assert.AreEqual(Location.House, penguin.Location);
            Assert.AreEqual(2, penguin.LegCount());
            Assert.AreEqual(false, penguin.IsWild());
            Assert.AreEqual(true, house.AddAnimal(penguin));
            Assert.AreEqual("Honk", penguin.MakeSound());
        }
        [TestMethod]
        public void CreateWildPigeon()
        {
            Pigeon pigeon = new Pigeon();

            Assert.AreEqual("Pigeon", pigeon.Name);
            Assert.AreEqual(Location.Wild, pigeon.Location);
            Assert.AreEqual(2, pigeon.LegCount());
            Assert.AreEqual(true, pigeon.IsWild());
            Assert.AreEqual("Coo", pigeon.MakeSound());
        }
        [TestMethod]
        public void CreateZooPigeon()
        {
            Pigeon pigeon = new Pigeon();
            Zoo zoo = new Zoo();

            zoo.AddAnimal(pigeon);

            Assert.AreEqual("Pigeon", pigeon.Name);
            Assert.AreEqual(Location.Zoo, pigeon.Location);
            Assert.AreEqual(2, pigeon.LegCount());
            Assert.AreEqual(false, pigeon.IsWild());
            Assert.AreEqual(true, zoo.AddAnimal(pigeon));
            Assert.AreEqual("Coo", pigeon.MakeSound());
        }
        [TestMethod]
        public void CreateHousePigeon()
        {
            Pigeon pigeon = new Pigeon();
            House house = new House();

            house.AddAnimal(pigeon);

            Assert.AreEqual("Pigeon", pigeon.Name);
            Assert.AreEqual(Location.House, pigeon.Location);
            Assert.AreEqual(2, pigeon.LegCount());
            Assert.AreEqual(false, pigeon.IsWild());
            Assert.AreEqual(true, house.AddAnimal(pigeon));
            Assert.AreEqual("Coo", pigeon.MakeSound());
        }
        [TestMethod]
        public void FlyAwayPigeon()
        {
            Pigeon pigeon = new Pigeon();

            pigeon.FlyAway();

            Assert.AreEqual("Pigeon", pigeon.Name);
            Assert.AreEqual(Location.Wild, pigeon.Location);
            Assert.AreEqual(2, pigeon.LegCount());
            Assert.AreEqual(true, pigeon.IsWild());
            Assert.AreEqual("Coo", pigeon.MakeSound());
        }
        [TestMethod]
        public void AnimalToString()
        {
            Cat cat = new Cat();

            Assert.AreEqual("The Cat goes Meow in the Wild", cat.ToString());
        }
    }
}
