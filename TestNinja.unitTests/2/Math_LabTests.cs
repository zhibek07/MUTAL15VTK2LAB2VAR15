using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests
{
    [TestFixture]
    public class Math_LabTests
    {
        private Math_Lab1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }
        [Test]
        /*15 variant
         * if ((a && b)|| (!a && !b))
                return false;
            if (!((a && b) || (!a && !b)))
                return true;
            return true;*/
        [TestCase(false, true, false)]
        [TestCase(false, false, true)]
        public void LogicalXOR_1_2_metod_Returns(bool a, bool b, bool XOR)
        {
            var result = _math.LogicalXOR(a, b);
            Assert.That(result == XOR);
        }
        
    }
}
