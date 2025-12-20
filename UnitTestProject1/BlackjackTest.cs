using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WindowsProgrammingFinalProject.Blackjack;

namespace UnitTest
{
    [TestClass]
    public class BlackjackTests
    {
        [TestMethod]
        public void TestCalculatePoints_NormalCards()
        {
            // 測試普通數字與 JQK
            var game = new Blackjack();
            var hand = new List<string> { "黑桃10", "紅心J" };

            int points = game.CalculatePoints(hand);

            Assert.AreEqual(20, points);
        }

        [TestMethod]
        public void TestCalculatePoints_AceAs11()
        {
            // 測試 A 是否能正確當作 11 分 (A + 9 = 20)
            var game = new Blackjack();
            var hand = new List<string> { "黑桃A", "梅花9" };

            int points = game.CalculatePoints(hand);

            Assert.AreEqual(20, points);
        }

        [TestMethod]
        public void TestCalculatePoints_AceAs1()
        {
            // 測試當總分超過 21 時，A 是否會降為 1 分 (A + 9 + 5 = 15)
            var game = new Blackjack();
            var hand = new List<string> { "黑桃A", "梅花9", "方塊5" };

            int points = game.CalculatePoints(hand);

            Assert.AreEqual(15, points);
        }

        [TestMethod]
        public void TestGetCard_ReducesDeckCount()
        {
            // 測試抽牌後，牌堆數量是否減少
            var game = new Blackjack();
            var deck = game.GenerateRandomDeck(); // 52張
            int initialCount = deck.Count;

            game.GetCard(deck);

            Assert.AreEqual(initialCount - 1, deck.Count);
        }

        [TestMethod]
        public void TestGameStart_InitialHands()
        {
            // 測試遊戲開始後，雙方是否都拿到 2 張牌
            var game = new Blackjack();
            game.GameStart();

            Assert.AreEqual(2, game.PlayerHand.Count);
            Assert.AreEqual(2, game.ComputerHand.Count);
        }
    }
}