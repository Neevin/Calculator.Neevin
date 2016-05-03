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
                    break;
                case "button2":
                    return new Division();
                    break;
                case "button3":
                   return new Addition();
                    break;
                case "button4":
                   return new Multiplication();
                    break;
                default:
                    throw new Exception("Неизвестная операция ");
            }

        }
    }
}