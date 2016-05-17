using System;
using Calculator.Neevin.OneArgument;

namespace Calculator.Neevin.TwoArgument
{
    public class Log : ISingleInterface
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
         
    }
}