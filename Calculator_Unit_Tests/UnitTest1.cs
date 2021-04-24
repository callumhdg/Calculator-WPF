using NUnit.Framework;
using Calculator_Back_End;

namespace Calculator_Unit_Tests
{
    public class Tests
    {


        [TestCase(3, 5, 8)]
        [TestCase(83, 47, 130)]
        [TestCase(64, -70, -6)]
        public void AddMethodWorksAsIntended(int x, int y, int expected)
        {
            int actual = Calculator.Add(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(7, 2, 5)]
        [TestCase(194, 74, 120)]
        [TestCase(55, -30, 85)]
        public void SubtractMethodWorksAsIntended(int x, int y, int expected)
        {
            int actual = Calculator.Subtract(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(6, 4, 24)]
        [TestCase(8, 8, 64)]
        [TestCase(100, 90, 9000)]
        public void MultiplyMethodWorksAsIntended(int x, int y, int expected)
        {
            int actual = Calculator.Multiply(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(12, 4, 3)]
        [TestCase(60, 15, 4)]
        [TestCase(-90, 90, -1)]
        public void DevideMethodWorksAsIntended(int x, int y, int expected)
        {
            int actual = Calculator.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }


    }
}