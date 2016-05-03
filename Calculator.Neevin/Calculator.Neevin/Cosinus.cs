using System;

namespace Calculator.Neevin
{
    public class Cosinus : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}