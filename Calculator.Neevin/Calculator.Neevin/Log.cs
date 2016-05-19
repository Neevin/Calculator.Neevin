using System;

namespace Calculator.Neevin
{
    public class Log : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
         
    }
}