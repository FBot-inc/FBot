using System.Linq;
using Domain.Domain;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Domain.Test.Domain
{
    [TestFixture]
    public class IntentTests
    {
        [Test]
        public void AddTemplate_AddTemplate_ExceptedListShouldAddedTemplate()
        {
            var intent = new Intent();
            var template = new Template("привет");

            intent.AddTemplate(template);

            var result = intent.GetTemplates().Contains(template);

            Assert.IsTrue(result);
        }

        [Test]
        public void AddTemplate_AddSomeTemplateWithOneLink_ShouldAddedOneTemplate()
        {
            var intent = new Intent();
            var template = new Template("asdf");

            intent.AddTemplate(template);
            intent.AddTemplate(template);

            var result = intent.GetTemplates().Count == 1;

            Assert.IsTrue(result);
        }

        [Test]
        public void AddTemplate_AddSomeTemplate_ShouldAddedOneTemplate()
        {
            var intent = new Intent();
            var template = new Template("asdf");
            var template1 = new Template("asdf");

            intent.AddTemplate(template);
            intent.AddTemplate(template1);

            var result = intent.GetTemplates().Count == 1;

            Assert.IsTrue(result);
        }
    }
}