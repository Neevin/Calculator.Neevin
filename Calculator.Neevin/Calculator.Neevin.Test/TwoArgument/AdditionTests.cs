using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.TwoArgument
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void SimpleAddTest()
        {
            ICalculate calculator = new Addition();
            double result = calculator.Calculate(4, 4);
            Assert.AreEqual(8, result);
        }

    }
}

