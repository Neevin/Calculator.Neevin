using System;

namespace Calculator.Neevin.OneArgument
{
    public class Exp : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
         
    }
}