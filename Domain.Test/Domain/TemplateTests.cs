using Domain.Domain;
using NUnit.Framework;

namespace Domain.Test.Domain
{
    [TestFixture]
    public class TemplateTests
    {
        [Test]
        public void Recognize_CheckFullEquals_ExceptedTrue()
        {
            ITemplate template = new Template("привет");

            var result = template.Recognize("привет");

            Assert.IsTrue(result);
        }
    
        [Test]
        public void Recognize_CheckNotEquals_ExceptedFalse()
        {
            ITemplate template = new Template("привет");

            var result = template.Recognize("привет1");
            
            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_ObjectOtherType_ExceptedFalse()
        {
            var template = new Template("asdf");

            var result = template.Equals(new Intent());

            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_ObjectIsNull_ExceptedFalse()
        {
            var template = new Template("asdf");

            var result = template.Equals(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_ObjectIsLike_ExceptedTrue()
        {
            var template = new Template("asdf");
            var template1 = new Template("asdf");

            var result = template.Equals(template1);

            Assert.IsTrue(result);
        }
    }
}
