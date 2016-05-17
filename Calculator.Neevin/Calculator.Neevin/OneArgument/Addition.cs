using Calculator.Neevin.TwoArgument;

namespace Calculator.Neevin.OneArgument
{
    public class Addition : ICalculate
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}