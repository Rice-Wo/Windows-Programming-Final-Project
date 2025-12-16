using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsProgrammingFinalProject.GuessNumber;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {

        
        [TestMethod]
        public void CorrectAnser()
        {
            GuessNumber game = new GuessNumber();
            int anser = 1234; // 假設答案是1234
            string result = game.MakeGuess(1234, anser);

            Assert.IsTrue(result.Equals("恭喜，答案1234正確！你總共猜了 1 次。"));
        }

        [TestMethod]
        public void oneA()
        {
            GuessNumber game = new GuessNumber();
            int anser = 1234; // 假設答案是1234
            string result = game.MakeGuess(1111, anser);

            Assert.IsTrue(result.Equals("1A0B"));
        }
    }
}