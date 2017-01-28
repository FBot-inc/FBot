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
        public void Recognize_CheckSimpleString_ExceptedFalse()
        {
            var intent = new Intent();

            var template1 = new SimpleTemplate("привет");

            intent.AddTemplate(template1);

            var result1 = intent.Recognize("afsdfasdf").ResultOfComparisin;

            Assert.IsFalse(result1);
        }

        [Test]
        public void Recognize_CheckSimpleString_ExceptedTrue()
        {
            var intent = new Intent();

            var template1 = new SimpleTemplate("привет");
            var template2 = new SimpleTemplate("здарова");

            intent.AddTemplate(template1);
            intent.AddTemplate(template2);

            var result1 = intent.Recognize("привет").ResultOfComparisin;
            var result2 = intent.Recognize("здарова").ResultOfComparisin;

            Assert.IsTrue(result1 && result2);
        }

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

        [Test]
        public void DeleteTemplate_DeleteTemplate_ExpectedFalse()
        {
            var intent = new Intent();
            var template = new SimpleTemplate("simpleTemplate");

            intent.AddTemplate(template);
            intent.DeleteTemplate(template);

            var result = intent.GetTemplates().Contains(template);

            Assert.IsFalse(result);
        }
    }
}