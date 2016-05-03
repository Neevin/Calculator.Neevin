using System;

namespace Calculator.Neevin
{
    public static class Factory
    {
        public static ICalculate CreateCalculate(string name)
        {
            switch (name)
            {
                case "button1":
                    return new Substraction();
                case "button2":
                    return new Division();
                case "button3":
                    return new Addition();
                case "button4":
                    return new Multiplication();
                default:
                    throw new Exception("Неизвестная операция ");
            }

        }
    }
}