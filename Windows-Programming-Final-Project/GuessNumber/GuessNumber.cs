using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsProgrammingFinalProject.GuessNumber
{


    public class GuessNumber
    {
        int anser;
        int guessCount = 0;
        public int GetAnser()
        {
            Random rand = new Random();
            return rand.Next(1001, 10000);
        }

        public string MakeGuess(int userGuess, int anser)
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
                HashSet<char> usedDigits = new HashSet<char>();

                int A = 0; // 數字和位置都正確的數量
                int B = 0; // 數字正確但位置錯誤的數量

                for (int i = 0; i < strUserGuess.Length; i++)
                {
                    char ch = strUserGuess[i];

                    if (strUserGuess[i] == strAnser[i])
                    {
                        usedDigits.Add(ch);
                        A++; // 數字和位置都正確
                    }
                    else if (strAnser.Contains(strUserGuess[i]) && usedDigits.Add(ch))
                    {
                        B++; // 數字正確但位置錯誤
                    }

                }
                return $"{A}A{B}B";
            }

        }
    }
}
