using System;
using Calculator.Neevin.OneArgument;
using Calculator.Neevin.TwoArgument;
using NUnit.Framework;

namespace Calculator.Neevin.Test.OneArgument
{
    public class SingleFactoryTests
    {
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("sin", typeof(Sinus))]
        [TestCase("log", typeof(Log))]
        [TestCase("exp", typeof(Exp))]
        [TestCase("sqrt", typeof(Sqrt))]
        public void SimpleCosTest(string name, Type type)
        {
            ISingleInterface calculator = SingleFactory.CreateCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}