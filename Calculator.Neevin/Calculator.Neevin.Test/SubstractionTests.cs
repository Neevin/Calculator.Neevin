using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test
{
     [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SimpleSubstractionTest()
        {
            ICalculate calculator = new Substraction();
            double result = calculator.Calculate(5, 4);
            Assert.AreEqual(1, result);
        } 
    }
}