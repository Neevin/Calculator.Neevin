using System;

namespace Calculator.Neevin.OneArgument
{
    public class Sinus : ISingleInterface
    {
        public double Calculate(double first)
        {
         return Math.Sin(first);   
        }
    }
}
   