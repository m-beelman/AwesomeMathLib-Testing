using AwesomeMathLib;
using NUnit.Framework;

namespace AweseomeMathLib.Test
{
    public class Tests
    {
        [Test]
        [TestCase(1,1,2)]
        public void TestAdd(int first, int second, int result)
        {
            Assert.AreEqual(BasicCalculations.Add(first, second), result);
        }

        [Test]
        [TestCase(1, 1, 0)]
        public void TestSubtract(int first, int second, int result)
        {
            Assert.AreEqual(BasicCalculations.Subtract(first, second), result);
        }

        [Test]
        [TestCase(1, 1, 1)]
        public void TestMultiply(int first, int second, int result)
        {
            Assert.AreEqual(BasicCalculations.Multiply(first, second), result);
        }
        
        [Test]
        [TestCase(1, 1, 1)]
        public void TestDivide(int first, int second, int result)
        {
            Assert.AreEqual(BasicCalculations.Divide(first, second), result);
        }


    }
}