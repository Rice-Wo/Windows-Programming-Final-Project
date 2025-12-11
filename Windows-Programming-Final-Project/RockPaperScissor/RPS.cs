using System;

namespace WindowsProgrammingFinalProject.RockPaperScissor
{
    public class RPS
    {
        public static readonly string[] input = { "石頭", "剪刀", "布" };
        int winCount = 0;
        int loseCount = 0;
        int drawCount = 0;

        public string Game(string userInput, int comInput)
        {
            int user = Array.IndexOf(input, userInput);
            if (user == -1)
            {
                Console.WriteLine("輸入異常");
                return "輸入異常";
            }
            int computer = comInput;


            int result = (user - computer + 3) % 3;

            string resultMessage = result switch
            {
                0 => $"電腦出{input[computer]}，平手",
                1 => $"電腦出{input[computer]}，你輸了",
                2 => $"電腦出{input[computer]}，你贏了",
                _ => $"輸入異常"
            };
            switch (result)
            {
                case 0:
                    drawCount++;
                    break;
                case 1:
                    loseCount++;
                    break;
                case 2:
                    winCount++;
                    break;
                default:
                    break;
            }
            ;

            Console.WriteLine(resultMessage);
            return resultMessage;
        }

        public int GetRandomInput()
        {
            Random rand = new Random();
            return rand.Next(0, 3);
        }

        /// <summary>
        /// 回傳目前的勝負平統計
        /// </summary>
        /// <returns>一個陣列包含[勝場數, 敗場數, 平手數]</returns>
        public int[] Statistics()
        {
            Console.WriteLine($"勝場數: {winCount}, 敗場數: {loseCount}, 平手數: {drawCount}");
            return new int[] { winCount, loseCount, drawCount };
        }
    }
}
