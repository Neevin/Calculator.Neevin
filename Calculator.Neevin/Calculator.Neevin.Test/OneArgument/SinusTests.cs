using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    [TestFixture]
    public class SinusTests
    {

        [TestCase(0, 0)]
        [TestCase(2, 0.909)]
        [TestCase(1, 0.841470)]
        public void SimpleSinTest(double firstArgument, double expected)
        {
            ISingleInterface calculator = new Sinus();
            double result = calculator.Calculate(firstArgument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}
