using System;

namespace Calculator.Neevin.OneArgument
{
    public class Cosinus : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}