using System.Collections.Generic;

namespace ChatBots
{
    public class MimicPlusBot : IChatBot
    {
        public string Name { get; } = "MimicPlus";

        public string WelcomeText { get; } = "";

        public List<string> MessageHistory { get; } = new List<string>();

        public string SendMessage(string message)
        {
            MessageHistory.Add(message);
            return string.Join("\n", MessageHistory.ToArray());
        }
    }
}