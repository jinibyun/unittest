using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UpgradeServiceTest
    {
        // without fakes
        [TestMethod]
        public void TestCurrentSWVersion()
        {
            int expected = 5;
            UpgradeService us = new UpgradeService();
            int actual = us.currentSWVersion(1);
            Assert.AreEqual(expected, actual, "Same Versions found");

        }

        // NOTE: There are two ways: Stub and Shims
        // using Stub over interface
        [TestMethod]
        public void TestCurrentSWVersionWithFake()
        {
            int expected = 10;
            IUpgradeService us = new ClassLibrary1.Fakes.StubIUpgradeService()
                {
                    // Definitions for multiple methods can be combined by separating by commas.
                    CurrentSWVersionInt32 = (DeviceID) => { return 10;},
                    IsSWUpgradeRequiredInt32 = (DeviceID) => { return true; }
                };
            int actual = us.currentSWVersion(1);
            Assert.AreEqual(expected, actual, "Same Versions found");

        }

        // Shims: skipped
    }
}
