using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test
{
    [TestFixture]
    public class MultiplicationTests
    {

        [TestCase(16, 4, 12)]
        [TestCase(6, 1, 5)]
        [TestCase(10, 8, 2)]
        public void SimpleMultiplicationTest(double firstArgument, double secondArgument, double expected)
        {
            ICalculate calculator = new Multiplication();
            double result = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result);
        }
    }
}