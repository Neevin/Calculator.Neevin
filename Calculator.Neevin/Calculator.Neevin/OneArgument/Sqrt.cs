using System;

namespace Calculator.Neevin.OneArgument
{
    public class Sqrt : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
         
    }
}