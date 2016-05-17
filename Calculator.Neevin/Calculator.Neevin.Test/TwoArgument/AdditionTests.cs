using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.TwoArgument
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(4, 4, 8)]
        [TestCase(6, 2, 8)]
        [TestCase(3, 8, 11)]
        public void SimpleAddTest(double firstArgument, double secondArgument, double expected)
        {
            ICalculate calculator = new Addition();
            double result = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result);
        }

    }
}

