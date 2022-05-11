using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketService;

namespace RocketTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FlyToMoonFail()
        {
            Rocket r = new Rocket();

            Assert.AreNotEqual(29000, r.Speed);
            Assert.AreNotEqual(true, r.EnginesAreWorking);
            Assert.AreNotEqual("To the Moon!", r.Direction);
        }
        [TestMethod]
        public void FlyToMoonPass()
        {
            Rocket r = new Rocket();
            r.FlyToTheMoon();

            Assert.AreEqual(29000, r.Speed);
            Assert.AreEqual(true, r.EnginesAreWorking);
            Assert.AreEqual("To the Moon!", r.Direction);
        }

        // failing tests
        
        //[TestMethod]
        //public void SpeedTestFail() // speed test
        //{
        //    Rocket r = new Rocket();

        //    Assert.AreNotEqual(29000, r.Speed);
        //}
        //[TestMethod]
        //public void EngineTestPassFail() // engine test
        //{
        //    Rocket r = new Rocket();

        //    Assert.AreNotEqual(true, r.EnginesAreWorking);
        //}
        //[TestMethod]
        //public void DirectionTestFail() // direction test
        //{
        //    Rocket r = new Rocket();

        //    Assert.AreNotEqual("To the Moon!", r.Direction);
        //}

        // passing tests
        
        //[TestMethod]
        //public void SpeedTestPass() // speed test
        //{
        //    Rocket r = new Rocket();
        //    r.FlyToTheMoon();

        //    Assert.AreEqual(29000, r.Speed);
        //}
        //[TestMethod]
        //public void EngineTestPass() // engine test
        //{
        //    Rocket r = new Rocket();
        //    r.FlyToTheMoon();

        //    Assert.AreEqual(true, r.EnginesAreWorking);
        //}
        //[TestMethod]
        //public void DirectionTestPass() // direction test
        //{
        //    Rocket r = new Rocket();
        //    r.FlyToTheMoon();

        //    Assert.AreEqual("To the Moon!", r.Direction);
        //}
    }
}