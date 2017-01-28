using System.Collections.Generic;
using System.Linq;
using Domain.Domain.Recognize;
using Domain.Domain.Recognize.Intents;

namespace Domain.Domain
{
    public class MessageGraph
    {
        public List<Intent> Heads = new List<Intent>();

        public List<Intent> Intents = new List<Intent>();
        public List<Message> Messages = new List<Message>();

        public List<LinkFromIntentToMessage> LinksFromIntentToMessage = new List<LinkFromIntentToMessage>();
        public List<LinkFromMessageToIntent> LinksFromMessageToIntent = new List<LinkFromMessageToIntent>();
        public List<LinkFromMessageToMessage> LinksFromMessageToMessage = new List<LinkFromMessageToMessage>();

        public Dictionary<string, List<Intent>> CurrentIntents = new Dictionary<string, List<Intent>>();
        public Dictionary<string, List<Message>> MessageForRead = new Dictionary<string, List<Message>>();

        public bool Next(string userMessage, string userId)
        {
            if (!CurrentIntents.ContainsKey(userId))
            {
                CurrentIntents[userId] = new List<Intent>();
                CurrentIntents[userId].AddRange(Heads);
            }

            var intent = CurrentIntents[userId].FirstOrDefault(p => p.Equals(userMessage));

            if (intent == null)
            {
                return false;
            }

            var result = new List<Message>();

            var message = LinksFromIntentToMessage.FirstOrDefault(p => p.From.Equals(intent))?.To;

            result.Add(message);

            do
            {
                message = LinksFromMessageToMessage.FirstOrDefault(p => p.From.Equals(message))?.To;
                result.Add(message);
            } while (message != null);

            MessageForRead.Add(userId, result);

            var nextIntentsLink = LinksFromMessageToIntent.Where(p => p.From.Equals(MessageForRead[userId].Last()));

            var nextIntents = nextIntentsLink.Select(p => p.To).ToList();

            CurrentIntents[userId].Clear();
            CurrentIntents[userId].AddRange(nextIntents);

            return true;
        }

        public List<Message> Read(string userId)
        {
            return MessageForRead[userId];
        }

        public void Reset(string userId)
        {
            CurrentIntents.Remove(userId);
            MessageForRead.Remove(userId);
        }
    }

}