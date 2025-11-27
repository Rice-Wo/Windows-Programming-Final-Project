using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsProgrammingFinalProject.RockPaperScissor;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RPS rps = new RPS();
            string result = rps.Game("石頭");
            Assert.IsTrue(result.Contains("電腦出"));
        }
    }
}
