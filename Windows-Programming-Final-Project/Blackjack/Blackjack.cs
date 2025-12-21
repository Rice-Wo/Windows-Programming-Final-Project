using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsProgrammingFinalProject.Blackjack
{
    /* Blackjack 遊戲邏輯類別
     * 包含生成牌組、洗牌、發牌、計算分數等功能
     * 這東西是用我之前寫的 Python 用AI改寫成 C#
     */
    public class Blackjack
    {
        public List<string> PlayerHand { get; private set; }
        public List<string> ComputerHand { get; private set; }
        public List<string> Deck { get; private set; }
        public int PlayerPoint { get; private set; }
        public int ComPoint { get; private set; }

        private Random rand = new Random();

        public Blackjack()
        {
            PlayerHand = new List<string>();
            ComputerHand = new List<string>();
            Deck = new List<string>();
        }

        // 生成並洗牌
        public List<string> GenerateRandomDeck()
        {
            Deck.Clear();
            string[] suits = { "黑桃", "紅心", "方塊", "梅花" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Deck.Add(suit + rank);
                }
            }

            // Fisher-Yates 洗牌演算法 (等同於 Python 的 random.shuffle)
            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (Deck[j], Deck[i]) = (Deck[i], Deck[j]);
            }
            return Deck;
        }

        // 抽牌 (等同於 Python 的 pop)
        public string GetCard(List<string> deck)
        {
            if (deck.Count == 0) return "";
            string card = deck[deck.Count - 1]; // 拿最後一張
            deck.RemoveAt(deck.Count - 1);     // 移除
            return card;
        }

        // 計算分數
        public int CalculatePoints(List<string> hand)
        {
            int point = 0;
            int aNum = 0;

            foreach (var card in hand)
            {
                // 在 C# 中，card[0]和[1]通常是花色(如'黑','桃')，所以從索引 2 開始截取
                string rank = card.Substring(2);

                if (rank == "J" || rank == "Q" || rank == "K")
                    point += 10;
                else if (rank == "A")
                    aNum += 1;
                else
                    point += int.Parse(rank);
            }

            point += aNum;

            // 處理 A 是否要當成 11 分
            for (int i = 0; i < aNum; i++)
            {
                if (point <= 11)
                    point += 10;
            }

            return point;
        }

        public void GameStart()
        {
            GenerateRandomDeck();
            PlayerHand = new List<string> { GetCard(Deck), GetCard(Deck) };
            PlayerPoint = CalculatePoints(PlayerHand);
            ComputerHand = new List<string> { GetCard(Deck), GetCard(Deck) };
        }

        public void GameAddCard()
        {
            PlayerHand.Add(GetCard(Deck));
            PlayerPoint = CalculatePoints(PlayerHand);
        }

        public void GameEnd()
        {
            ComPoint = CalculatePoints(ComputerHand);

            
                // 莊家低於 17 分強制補牌
            while (ComPoint < 17)
            {
                ComputerHand.Add(GetCard(Deck));
                ComPoint = CalculatePoints(ComputerHand);
            }
            
            PlayerPoint = CalculatePoints(PlayerHand);
        }

        public string GetResult()
        {
            if (PlayerPoint > 21)
                return "你爆了！莊家獲勝！";
            else if (ComPoint > 21)
                return "莊家爆了！你獲勝！";
            else if (PlayerPoint > ComPoint)
                return "你獲勝了！";
            else if (PlayerPoint < ComPoint)
                return "莊家獲勝！";
            else
                return "平手！";
        }
    }
}
