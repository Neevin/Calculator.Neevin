using System;

namespace Calculator.Neevin
{
    public static class SingleFactory
    {
        public static ISingleInterface CreateCalculate(string name)
        {
            switch (name)
            {
                case "cos":
                    return new Cosinus();
                case "sin":
                    return new Sinus();
                default:
                    throw new Exception("Неизвестная операция ");
            }
        }
    }
}