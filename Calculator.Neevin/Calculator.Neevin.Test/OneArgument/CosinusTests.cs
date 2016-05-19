using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.540)]
        [TestCase(3, -0.98999)]
        public void SimpleCosTest(double firstArgument, double expected)
        {
            ISingleInterface calculator = new Cosinus();
            double result = calculator.Calculate(firstArgument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}
