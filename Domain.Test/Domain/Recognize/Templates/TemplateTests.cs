using Domain.Domain.Recognize.Intents;
using Domain.Domain.Recognize.Templates;
using NUnit.Framework;

namespace Domain.Test.Domain.Recognize.Templates
{
    [TestFixture]
    public class TemplateTests
    {
        [Test]
        public void Recognize_CheckFullEquals_ExceptedTrue()
        {
            ITemplate template = new SimpleTemplate("привет");

            var result = template.Recognize("привет");

            Assert.IsTrue(result.ResultOfComparisin);
        }
    
        [Test]
        public void Recognize_CheckNotEquals_ExceptedFalse()
        {
            ITemplate template = new SimpleTemplate("привет");

            var result = template.Recognize("привет1");
            
            Assert.IsFalse(result.ResultOfComparisin);
        }

        [Test]
        public void Equals_ObjectOtherType_ExceptedFalse()
        {
            var template = new SimpleTemplate("asdf");

            var result = template.Equals(new Intent());

            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_ObjectIsNull_ExceptedFalse()
        {
            var template = new SimpleTemplate("asdf");

            var result = template.Equals(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_ObjectIsLike_ExceptedTrue()
        {
            var template = new SimpleTemplate("asdf");
            var template1 = new SimpleTemplate("asdf");

            var result = template.Equals(template1);

            Assert.IsTrue(result);
        }
    }
}
