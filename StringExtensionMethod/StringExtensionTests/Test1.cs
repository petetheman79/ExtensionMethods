using NUnit.Framework;
using StringExtensionMethod;

namespace StringExtensionTests
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void TestMethod1()
        {
            var sentence = "Mary had a little lamb";
            Assert.AreEqual(5, sentence.WordCount());
        }
    }
}