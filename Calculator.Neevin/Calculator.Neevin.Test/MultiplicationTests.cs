using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test
{
    [TestFixture]
    public class MultiplicationTests
    {

        [Test]
        public void SimpleMultiplicationTest()
        {
            ICalculate calculator = new Multiplication();
            double result = calculator.Calculate(16, 4);
            Assert.AreEqual(12, result);
        }
    }
}