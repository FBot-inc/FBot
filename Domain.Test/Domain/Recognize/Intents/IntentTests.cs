using System.Linq;
using Domain.Domain.Recognize.Intents;
using Domain.Domain.Recognize.Templates;
using NUnit.Framework;

namespace Domain.Test.Domain.Recognize.Intents
{
    [TestFixture]
    public class IntentTests
    {
        [Test]
        public void AddTemplate_AddTemplate_ExceptedListShouldAddedTemplate()
        {
            var intent = new Intent();
            var template = new SimpleTemplate("привет");

            intent.AddTemplate(template);

            var result = intent.GetTemplates().Contains(template);

            Assert.IsTrue(result);
        }

        [Test]
        public void AddTemplate_AddSomeTemplateWithOneLink_ShouldAddedOneTemplate()
        {
            var intent = new Intent();
            var template = new SimpleTemplate("asdf");

            intent.AddTemplate(template);
            intent.AddTemplate(template);

            var result = intent.GetTemplates().Count == 1;

            Assert.IsTrue(result);
        }

        [Test]
        public void AddTemplate_AddSomeTemplate_ShouldAddedOneTemplate()
        {
            var intent = new Intent();
            var template = new SimpleTemplate("asdf");
            var template1 = new SimpleTemplate("asdf");

            intent.AddTemplate(template);
            intent.AddTemplate(template1);

            var result = intent.GetTemplates().Count == 1;

            Assert.IsTrue(result);
        }
    }
}