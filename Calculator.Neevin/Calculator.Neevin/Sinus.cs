using System;

namespace Calculator.Neevin
{
    public class Sinus : ISingleInterface
    {
        public double Calculate(double first)
        {
         return Math.Sin(first);   
        }
    }
}
   