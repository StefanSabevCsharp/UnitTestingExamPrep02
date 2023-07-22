using NUnit.Framework;

namespace RobotFactory.Tests
{
    public class Tests
    {
        //have to create all test for factory
        //start testing constructor
        [Test]
        public void TestConstructor()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual("Factory", factory.Name);
            Assert.AreEqual(10, factory.Capacity);
        }
        [Test]
        public void TestConstructorRobots()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual(0, factory.Robots.Count);
        }
        [Test]
        public void TestConstructorSupplements()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual(0, factory.Supplements.Count);
        }
        //test ctor factory for name
        [Test]
        public void TestConstructorName()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual("Factory", factory.Name);
        }
        //test ctor factory for capacity
        [Test]
        public void TestConstructorCapacity()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual(10, factory.Capacity);
        }
        //test ctor factory for robots
        [Test]
        public void TestConstructorRobotsList()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual(0, factory.Robots.Count);
        }
        //test ctor factory for supplements
        [Test]
        public void TestConstructorSupplementsList()
        {
            Factory factory = new Factory("Factory", 10);
            Assert.AreEqual(0, factory.Supplements.Count);
        }
        [Test]
        public void TestProduceRobot()
        {
            Factory factory = new Factory("Factory", 10);
            string result = factory.ProduceRobot("Model", 10, 10);
            Assert.AreEqual($"Produced --> Robot model: ModelIS: 10, Price: 10.00", result);
          
        }


    }



}