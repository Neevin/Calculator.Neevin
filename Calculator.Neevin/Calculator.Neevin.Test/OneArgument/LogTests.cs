using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(1, 0)]
        [TestCase(10, 2.3)]
        [TestCase(100, 4.6)]
        public void SimpleLogTest(double firstArgument, double expected)
        {
            ISingleInterface calculator = new Log();
            double result = calculator.Calculate(firstArgument);
            Assert.AreEqual(expected, result, 0.01);
        }

    }
}
