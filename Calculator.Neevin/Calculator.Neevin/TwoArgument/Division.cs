using System;

namespace Calculator.Neevin.TwoArgument
{
    public class Division : ICalculate
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return first / second;
        }

    }
}

