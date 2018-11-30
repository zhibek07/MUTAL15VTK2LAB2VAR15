
using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests
{
    [TestFixture]
    public class Math_Lab2Tests
    {
        private Math_Lab2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab2();
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }



        //Общее задание 1
        //не работает
              [TestCase(2,1,1)]
              [TestCase(1,2,2)]
              [TestCase(1,1,1)]
              public void Add_WhenCalled_ReturnTheSunArguments(int a, int b, int expectedResult)
              {
                  var result = _math.Add(a, b);
                  Assert.That(result == expectedResult);
              }

        //работает
              [TestCase(2,1,3)]
              [TestCase(1,2,3)]
              [TestCase(1,1,2)]
              public void Add_WhenCalled_ReturnTheSunOfArguments(int a, int b, int expectedResult)
              {
                  var result = _math.Add(a, b);
                  Assert.That(result== expectedResult);
              }



        /* 
        [Test]
                public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
                {
                    var result = _math.Max(2, 1);
                    Assert.That(result, Is.EqualTo(2));
                }

                [Test]
                public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
                {
                    var result = _math.Max(1, 2);
                    Assert.That(result, Is.EqualTo(2));
                }

                [Test]
                public void Max_ArgumentAreEqual_ReturnTheSameArgument()
                {
                    var result = _math.Max(1, 1);
                    Assert.That(result, Is.EqualTo(1));
                }*/
    }
}