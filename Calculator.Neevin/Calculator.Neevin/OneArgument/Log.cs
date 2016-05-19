using System;

namespace Calculator.Neevin.OneArgument
{
    /// <summary>
    /// Класс для логарифма
    /// </summary>
    public class Log : ISingleInterface
    {
        /// <summary>
        /// Вычисление для логарифма
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
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