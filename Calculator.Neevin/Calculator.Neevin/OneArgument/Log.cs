using System;

namespace Calculator.Neevin.OneArgument
{
    public class Log : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
         
    }
}