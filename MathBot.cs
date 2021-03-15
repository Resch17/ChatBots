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
            double output;
            switch (op)
            {
                case "addition":
                    output = Add(numberList);
                    break;
                case "subtraction":
                    output = Subtract(numberList);
                    break;
                case "multiplication":
                    output = Multiply(numberList);
                    break;
                case "division":
                    output = Divide(numberList);
                    break;
                default:
                    Console.WriteLine("Invalid operation. You get a zero.");
                    output = 0;
                    break;
            }

            return output.ToString();
        }

        private double Add(List<double> input)
        {
            return input.Sum();
        }

        private double Subtract(List<double> input)
        {
            double total = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                total -= input[i];
            }
            return total;
        }

        private double Multiply(List<double> input)
        {
            double total = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                total = total * input[i];
            }
            return total;
        }

        private double Divide(List<double> input)
        {
            double total = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == 0)
                {
                    Console.WriteLine("Nice try, but I'm not dividing by zero! Skipped!");
                }
                else
                {
                    total = total / input[i];
                }
            }
            return total;
        }
    }
}