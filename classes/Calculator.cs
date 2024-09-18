public class Calculator : ICalculator
{
    public double AddNumbers(double NumberA, double NumberB)
    {
        return NumberA + NumberB;
    }

    public double SubtractNumbers(double NumberA, double NumberB)
    {
        return NumberA - NumberB;
    }

    public double MultiplyNumbers( double NumberA, double NumberB)
    {
        return NumberA * NumberB;
    }

    public double DivideNumbers(double NumberA, double NumberB)
    {
        return NumberA / NumberB;
    }
}