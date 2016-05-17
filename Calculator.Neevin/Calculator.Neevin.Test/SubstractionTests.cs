using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(5, 4, 1)]
        [TestCase(6, 3, 3)]
        [TestCase(9, 8, 1)]
        public void SimpleSubstractionTest(double firstArgument, double secondArgument, double expected)
        {
            ICalculate calculator = new Substraction();
            double result = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result);
        }
    }
}