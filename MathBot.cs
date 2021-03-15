using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatBots
{
    public class MathBot : IChatBot
    {
        public string Name { get; } = "Math";

        public string WelcomeText { get; } = "Input numbers (separated by spaces) and I'll add them!";

        public string SendMessage(string message)
        {
            string[] numbersInput = message.Split(' ');
            List<double> numberList = new List<double>();
            foreach (string num in numbersInput)
            {
                double number;
                if (double.TryParse(num, out number))
                {
                    numberList.Add(number);
                }
                else
                {
                    Console.WriteLine($"\"{num}\" ain't no number I ever heard of!");
                }
            }
            double sum = numberList.Sum();
            return sum.ToString();
        }
    }
}