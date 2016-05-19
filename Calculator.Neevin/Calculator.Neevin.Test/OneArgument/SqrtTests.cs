using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        public void SimpleSqrtTest(double firstArgument, double expected)
        {
            ISingleInterface calculator = new Sqrt();
            double result = calculator.Calculate(firstArgument);
            Assert.AreEqual(expected, result, 0.0001);
        }

    }
}
