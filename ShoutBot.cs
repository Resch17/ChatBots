namespace ChatBots
{
    public class ShoutBot : IChatBot
    {
        public string Name { get; } = "Shout";
        public string WelcomeText { get; } = "";

        public string SendMessage(string message)
        {
            if (message.EndsWith('.') || message.EndsWith('?') || message.EndsWith('!'))
            {
                message = message.Remove(message.Length - 1, 1);
            }
            return message.ToUpper() + "!";
        }
    }
}