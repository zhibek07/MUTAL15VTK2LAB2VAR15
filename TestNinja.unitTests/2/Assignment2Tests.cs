using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 _massiv;
        [SetUp]
        public void SetUp()
        {
            _massiv = new Assignment2();
        }

        [Test]
        [TestCase(10, new int[] {1,2,3,5,7}, TestName = "Test 1")]
        [TestCase(10, new int[] {4, 6, 8, 9, 10 }, TestName = "Test 2")]
        public void PrimeNumbers_Length(int limit,int[] mas)
        {
            var result = _massiv.PrimeNumbers(limit); 
            Assert.That(result, Is.EquivalentTo(mas)); 
        } 
    }
}