using System;

namespace WindowsProgrammingFinalProject.RockPaperScissor
{
    public class RPS
    {
        public static readonly string[] input = { "石頭", "剪刀", "布" };
        public RPS() { }

        public string Game(string userInput, int? seed = null)
        {
            Random rand;
            if (seed == null)
            {
               rand  = new Random();
            }
            else
            {
                rand = new Random((int)seed);
            }
            int user = Array.IndexOf(input, userInput);
            int computer = rand.Next(0, 3);
            int result = (user - computer + 3) % 3;

            string resultMessage = result switch
            {
                0 => $"電腦出{input[computer]}，平手",
                1 => $"電腦出{input[computer]}，你贏了",
                2 => $"電腦出{input[computer]}，你輸了",
                _ => $"電腦出{input[computer]}，未知結果"
            };

            Console.WriteLine(resultMessage);
            return resultMessage;

        }


    }
}
