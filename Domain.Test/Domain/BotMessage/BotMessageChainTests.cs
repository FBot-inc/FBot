using Domain.Domain.BotMessage;
using NUnit.Framework;

namespace Domain.Test.Domain.BotMessage
{
    [TestFixture]
    internal class BotMessageChainTests
    {
        [Test]
        public void Insert_СheckContentsOfElementCollection_ExpectedContains()
        {
            var botMessage = new SimpleBotMessage("asdfa");
            var botMessageChain = new BotMessageChain();

            botMessageChain.Insert(botMessage);
            var containsResult = botMessageChain.GetMessages().Contains(botMessage);

            Assert.IsTrue(containsResult);
        }

        [Test]
        public void Insert_СheckContentsOfElementCollection_ExpectedNotContains()
        {
            var botMessage = new SimpleBotMessage("asdfa");
            var botMessageChain = new BotMessageChain();

            botMessageChain.Insert(botMessage);
            var containsResult = botMessageChain.GetMessages().Contains(new SimpleBotMessage("fweas"));

            Assert.IsFalse(containsResult);
        }

        [Test]
        public void InsertAfter_CheckContainsOfElementAfterOthreElements_Excepter()
        {
            var botMessage = new SimpleBotMessage("asdfa");
            var botMessage1 = new SimpleBotMessage("asdfa1234");
            var botMessageChain = new BotMessageChain();

            botMessageChain.Insert(botMessage);
            botMessageChain.Insert(botMessage1);

            var messages = botMessageChain.GetMessages();

            for (var i = 0; i < messages.Count; i++)
            {
                if (messages[i].Equals(botMessage))
                {
                    if (i == messages.Count - 1)
                    {
                        Assert.IsTrue(false);
                    }

                    Assert.IsTrue(messages[i + 1].Equals(botMessage1));

                    break;
                }

            }
        }
    }
}