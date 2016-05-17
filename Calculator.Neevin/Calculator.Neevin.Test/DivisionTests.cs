using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test
{
      [TestFixture]
    public class DivisionTests
    {
       
        [Test]
        public void SimpleDivisionTest()
        {
            ICalculate calculator = new Division();
            double result = calculator.Calculate(16, 4);
            Assert.AreEqual(4, result);
        }  
    }
}