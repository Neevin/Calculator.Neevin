using System;

namespace Calculator.Neevin.OneArgument
{
    public class Log : ISingleInterface
    {
        public double Calculate(double first)
        {
            if (first == -10)
            {
                throw new Exception("Деление на -10");
            }
            return Math.Log(first);
        }
         
    }
}