using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsProgrammingFinalProject.RockPaperScissor;

namespace UnitTest
{
    [TestClass]
    public class RPSTest
    {
        [TestMethod]
        /*
         * 測試玩家出石頭時，電腦會隨機出石頭、剪刀或布
         * { "石頭", "剪刀", "布" }
         * 0, 1, 2
         */
        public void stone1()
        {
            RPS rps = new RPS();
            string result = rps.Game("石頭", 0);
            Assert.IsTrue(result.Equals("電腦出石頭\n，平手"));
        }

        [TestMethod]
        public void stone2()
        {
            RPS rps = new RPS();
            string result = rps.Game("石頭", 1);
            Assert.IsTrue(result.Equals("電腦出剪刀\n，你贏了"));
        }

        [TestMethod]
        public void stone3()
        {
            RPS rps = new RPS();
            string result = rps.Game("石頭", 2);
            Assert.IsTrue(result.Equals("電腦出布\n，你輸了"));
        }

        [TestMethod]
        public void scissors1()
        {
            RPS rps = new RPS();
            string result = rps.Game("剪刀", 0);
            Assert.IsTrue(result.Equals("電腦出石頭\n，你輸了"));
        }

        [TestMethod]
        public void scissors2()
        {
            RPS rps = new RPS();
            string result = rps.Game("剪刀", 1);
            Assert.IsTrue(result.Equals("電腦出剪刀\n，平手"));
        }

        [TestMethod]
        public void scissors3()
        {
            RPS rps = new RPS();
            string result = rps.Game("剪刀", 2);
            Assert.IsTrue(result.Equals("電腦出布\n，你贏了"));
        }

        [TestMethod]
        public void paper1()
        {
            RPS rps = new RPS();
            string result = rps.Game("布", 0);
            Assert.IsTrue(result.Equals("電腦出石頭\n，你贏了"));
        }

        [TestMethod]
        public void paper2()
        {
            RPS rps = new RPS();
            string result = rps.Game("布", 1);
            Assert.IsTrue(result.Equals("電腦出剪刀\n，你輸了"));
        }

        [TestMethod]
        public void paper3()
        {
            RPS rps = new RPS();
            string result = rps.Game("布", 2);
            Assert.IsTrue(result.Equals("電腦出布\n，平手"));
        }

        [TestMethod]
        public void invalidInput()
        {
            RPS rps = new RPS();
            string result = rps.Game("awd", 0);
            Assert.IsTrue(result.Equals("輸入異常"));
        }
    }
}