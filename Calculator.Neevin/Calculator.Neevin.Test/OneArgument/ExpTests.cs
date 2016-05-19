using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(2, 7.38)]
        [TestCase(3, 20.08)]
        public void SimpleExpTest(double firstArgument, double expected)
        {
            ISingleInterface calculator = new Exp();
            double result = calculator.Calculate(firstArgument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}