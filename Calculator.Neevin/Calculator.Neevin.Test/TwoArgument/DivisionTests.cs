using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.TwoArgument
{
      [TestFixture]
    public class DivisionTests
    {

          [TestCase(16, 4, 4)]
          [TestCase(9, 3, 3)]
          [TestCase(24, 8, 3)]
          public void SimpleDivisionTest(double firstArgument, double secondArgument, double expected)
        {
            ICalculate calculator = new Division();
            double result = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result);
        }  
    }
}