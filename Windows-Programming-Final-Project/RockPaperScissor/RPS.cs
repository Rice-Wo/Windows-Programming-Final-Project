using System;

namespace WindowsProgrammingFinalProject.RockPaperScissor
{
    public class RPS
    {
        public static readonly string[] input = { "石頭", "剪刀", "布" };

        public string Game(string userInput, int? testInput = null)
        {
            int user = Array.IndexOf(input, userInput);
            if (user == -1) {
                Console.WriteLine("輸入異常");
                return "輸入異常";
            }
            int computer;
            if (testInput.HasValue) // for unit testing
            {
                computer = testInput.Value; 
            }else
            {
                Random rand = new Random();
                computer = rand.Next(0, 3);
            }
            
            int result = (user - computer + 3) % 3;

            string resultMessage = result switch
            {
                0 => $"電腦出{input[computer]}，平手",
                1 => $"電腦出{input[computer]}，你輸了",
                2 => $"電腦出{input[computer]}，你贏了",
                _ => $"輸入異常"
            };

            Console.WriteLine(resultMessage);
            return resultMessage;

        }


    }
}
