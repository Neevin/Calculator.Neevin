using System;
using Calculator.Neevin.OneArgument;

namespace Calculator.Neevin.TwoArgument
{
    public class Cosinus : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}