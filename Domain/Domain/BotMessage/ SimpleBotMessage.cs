namespace Domain.Domain.BotMessage
{
    /*
     * Класс представлет объект просто константного сообщения.
     * */

    public class  SimpleBotMessage : IBotMessage
    {
        public SimpleBotMessage(string messageText)
        {
            Text = messageText;
        }

        public string Text { get; }
    }
}