using System;

namespace Calculator.Neevin.TwoArgument
{
    /// <summary>
    /// Класс для деления
    /// </summary>
    public class Division : ICalculate
    {
        /// <summary>
        /// Вычисление деления
        /// </summary>
        /// <param name="first">первый аргумент</param>
        /// <param name="second">второй аргумент</param>
        /// <returns></returns>
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

