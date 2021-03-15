using System;
using System.Collections.Generic;

namespace ChatBots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why talk with people when there are bots?!?!");

            List<IChatBot> bots = CreateBots();
            bool stillPlaying = true;
            while (stillPlaying)
            {
                IChatBot chosenBot = ChooseBot(bots);
                HaveConversation(chosenBot);
                Console.Clear();
                Console.WriteLine("Keep chatting? (y/n)");
                Console.Write(" > ");
                string response = Console.ReadLine().ToLower();
                if (response == "n")
                {
                    stillPlaying = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        static List<IChatBot> CreateBots()
        {
            return new List<IChatBot>() {
                new MimicBot(),
                new ReverserBot(),
                new AnswererBot(),
                new QuestionerBot(),
                new DuckDuckGoBot(),
                new ShoutBot(),
                new MimicPlusBot(),
                new MathBot()
            };
        }

        static IChatBot ChooseBot(List<IChatBot> botOptions)
        {
            Console.WriteLine();
            Console.WriteLine("Choose a bot to chat with:");
            for (int i = 0; i < botOptions.Count; i++)
            {
                IChatBot bot = botOptions[i];
                Console.WriteLine($"  {i}) {bot.Name}");
            }
            Console.Write("> ");

            try
            {
                int chosenIndex = int.Parse(Console.ReadLine());
                return botOptions[chosenIndex];
            }
            catch
            {
                Console.WriteLine("You're bad at choosing. You'll get the bot I give you.");
                return botOptions[0];
            }
        }

        static void HaveConversation(IChatBot bot)
        {
            Console.WriteLine();
            Console.WriteLine("Keep chatting as long as you want.");
            Console.WriteLine("Enter a blank line to end the conversation.");

            if (!string.IsNullOrWhiteSpace(bot.WelcomeText))
            {
                BotWriteLine(bot, bot.WelcomeText);
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("> ");

                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string response = bot.SendMessage(input);
                BotWriteLine(bot, response);
            }

            Console.WriteLine("The chat is over. Good-bye.");
        }

        static void BotWriteLine(IChatBot bot, string text)
        {
            Console.Write($"{bot.Name}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
