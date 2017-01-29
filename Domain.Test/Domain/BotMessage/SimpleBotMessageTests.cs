using Domain.Domain.BotMessage;
using NUnit.Framework;

namespace Domain.Test.Domain.BotMessage
{
    [TestFixture]
    internal class SimpleBotMessageTests
    {
        [Test]
        public void Text_ComparisonParameterOfonstructorAndValueOfTextFiel_ExceptedEqual()
        {
            const string messageText = "messageText";
            var simpleBotMessage = new SimpleBotMessage(messageText);

            Assert.AreEqual(messageText, simpleBotMessage.Text);
        }

        [Test]
        public void Text_ComparisonParameterOfonstructorAndValueOfTextFiel_ExceptedNotEqual()
        {
            const string messageText = "messageText";
            var simpleBotMessage = new SimpleBotMessage(messageText);

            Assert.AreNotEqual("asdfasdf", simpleBotMessage.Text);
        }
    }
}
