using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsProgrammingFinalProject.GuessNumber
{


    public class GuessNumber
    {
        int guessCount = 0;
        public string GetAnser()
        {
            Random rand = new Random();
            return rand.Next(0, 10000).ToString("D4");
        }

        public string MakeGuess(string userGuess, string anser)
        {
            guessCount++;
            if (userGuess == anser)
            {
                return $"恭喜，答案{anser}正確！你總共猜了 {guessCount} 次。";
            }
            else
            {
                string strAnser = anser.ToString();
                string strUserGuess = userGuess.ToString();

                int A = 0; // 數字和位置都正確的數量
                int B = 0; // 數字正確但位置錯誤的數量

                bool[] answerUsed = new bool[4]; // 記錄答案中哪些位置已被 A 佔用
                bool[] guessUsed = new bool[4];  // 記錄猜測中哪些位置已被 A 佔用

                // 第一遍：只算 A
                for (int i = 0; i < 4; i++)
                {
                    if (strUserGuess[i] == strAnser[i])
                    {
                        A++;
                        answerUsed[i] = true;
                        guessUsed[i] = true;
                    }
                }

                // 第二遍：算 B（排除掉已經是 A 的位置）
                for (int i = 0; i < 4; i++)
                {
                    if (guessUsed[i]) continue; // 如果這個位置已經是 A，跳過

                    for (int j = 0; j < 4; j++)
                    {
                        // 如果答案的這個位置還沒被用過，且數字相同
                        if (!answerUsed[j] && strUserGuess[i] == strAnser[j])
                        {
                            B++;
                            answerUsed[j] = true; // 標記這個答案數字已被配對
                            break;
                        }
                    }
                }
                return $"{userGuess}\t{A}A{B}B";
            }

        }
    }
}
