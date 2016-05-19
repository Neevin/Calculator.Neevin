using System;
using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.TwoArgument
{
    public class FactoryTests
    {
        [TestCase("button3", typeof(Addition))]
        [TestCase("button4", typeof(Multiplication))]
        [TestCase("button2", typeof(Division))]
        [TestCase("button1", typeof(Substraction))]
        public void FactoryTest(string name, Type type)
        {
            ICalculate calculator = Factory.CreateCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }  
    }
}