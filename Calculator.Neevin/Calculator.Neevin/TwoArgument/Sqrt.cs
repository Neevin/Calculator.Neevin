using System;
using Calculator.Neevin.OneArgument;

namespace Calculator.Neevin.TwoArgument
{
    public class Sqrt : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
         
    }
}