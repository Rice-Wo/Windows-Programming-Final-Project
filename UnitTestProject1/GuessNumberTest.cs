using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsProgrammingFinalProject.GuessNumber;

namespace UnitTest
{
    [TestClass]
    public class GuessNumberTest
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

            Assert.IsTrue(result.Equals("1111\t1A0B"));
        }

        [TestMethod]
        public void twoAoneB()
        {
            GuessNumber game = new GuessNumber();
            int anser = 1234; // 假設答案是1234
            string result = game.MakeGuess(1245, anser);
            Assert.IsTrue(result.Equals("1245\t2A1B"));

        }
    }
}