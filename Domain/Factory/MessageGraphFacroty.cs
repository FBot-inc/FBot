using Domain.Domain;

namespace Domain.Factory
{
    public class MessageGraphFacroty
    {
        public static MessageGraph CreateHelloMessageGraph()
        {
            var helloGraph = new MessageGraph();

            /*var helloIntent = new Intent();
            helloIntent.AddTemplate("привет");
            helloIntent.AddTemplate("здарова");

            var howAreYouIntent = new Intent();
            howAreYouIntent.AddTemplate("как дела");

            var helloMessage = new Message {Text = "привет"};

            var goodMessage = new Message {Text = "хорошо"};

            var byeMessage = new Message {Text = "пока"};

            helloGraph.Intents.Add(helloIntent);
            helloGraph.Intents.Add(howAreYouIntent);

            helloGraph.Messages.Add(helloMessage);
            helloGraph.Messages.Add(goodMessage);
            helloGraph.Messages.Add(byeMessage);

            helloGraph.Heads.Add(helloIntent);

            helloGraph.LinksFromIntentToMessage.Add(new LinkFromIntentToMessage {From = helloIntent, To = helloMessage});
            helloGraph.LinksFromIntentToMessage.Add(new LinkFromIntentToMessage { From = howAreYouIntent, To = goodMessage });

            helloGraph.LinksFromMessageToIntent.Add(new LinkFromMessageToIntent {From = helloMessage, To = howAreYouIntent});

            helloGraph.LinksFromMessageToMessage.Add(new LinkFromMessageToMessage {From = goodMessage, To = byeMessage});
            */
            return helloGraph;
        }
    }
}