using A_Level;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        private DiscriminantAndSqrt1 sqrt;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase(2,4,1, 8)]
        [TestCase(1,-70,600, 2500)]
        [TestCase(4,-12,9, 0)]
        [TestCase(1, -2, -24, 100)]
        [TestCase(0, 0, 5, 0)]
        [TestCase(3, 0, 0, 0)]
        public void DecisionTest(int a, int b, int c, int expected)
        {
            sqrt.a = a;
            sqrt.b = b;
            sqrt.c = c;
            sqrt.Decision();
            var result = sqrt.d;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1, -70, 600, 60,10)]
        [TestCase(4, -12, 9, 1.5, 1.5)]
        [TestCase(1, -2, -24, 6, -4)]
        [TestCase(3, 0, 0, 0, 0)]
        public void UrTest(int a, int b, int c, double expected1, double expected2)
        {
            sqrt.a = a;
            sqrt.b = b;
            sqrt.c = c;
            sqrt.Decision();

            var result1 = sqrt.x1;
            var result2 = sqrt.x2;

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }
    }
}