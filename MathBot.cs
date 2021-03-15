using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatBots
{
    public class MathBot : IChatBot
    {
        public string Name { get; } = "Math";

        public string WelcomeText { get; } = "Input a mathematic operation followed by some numbers (separated by spaces) and I'll do it to 'em!\n       e.g.  \"addition 2 4 6\"";

        public string SendMessage(string message)
        {
            string[] allInput = message.Split(' ');
            string op = allInput[0].ToLower();
            string[] numbersInput = allInput.Skip(1).ToArray();
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
            return Math(numberList, op).ToString();
        }

        private double Math(List<double> input, string oper)
        {
            double output = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                switch (oper)
                {
                    case "addition":
                        output += input[i];
                        break;
                    case "subtraction":
                        output -= input[i];
                        break;
                    case "multiplication":
                        output = output * input[i];
                        break;
                    case "division":
                        if (input[i] == 0)
                        {
                            Console.WriteLine("Nice try, but I'm not dividing by zero! Skipped!");
                        }
                        else
                        {
                            output = output / input[i];
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. You get a zero.");
                        output = 0;
                        break;
                }
            }
            return output;
        }
    }
}