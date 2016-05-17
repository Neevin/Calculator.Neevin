using System;
using Calculator.Neevin.OneArgument;

namespace Calculator.Neevin.TwoArgument
{
    public class Exp : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
         
    }
}