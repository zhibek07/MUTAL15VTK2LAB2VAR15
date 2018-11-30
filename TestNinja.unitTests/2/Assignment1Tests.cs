using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment1();
        }

        [Test]
        [TestCase("one", "two", 1)]
        [TestCase("hi", "hello", 0)]
        public void MatchingWords_Length(string a, string b, int numResult)
        {
            var result = _math.MatchingWords(a,b);
            Assert.That(result == numResult);
        }
    }
}