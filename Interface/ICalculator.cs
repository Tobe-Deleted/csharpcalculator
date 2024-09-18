public interface ICalculator 
{
    /// <summary>
    /// Adding numbers
    /// </summary>
    /// <param name="NumberA"></param>
    /// <param name="NumberB"></param>
    /// <returns>NumberA + NumberB</returns>
    double AddNumbers(double NumberA, double NumberB);
    
    /// <summary>
    /// Subtracting numbers
    /// </summary>
    /// <param name="NumberA"></param>
    /// <param name="NumberB"></param>
    /// <returns>NumberA - NumberB</returns>      
    double SubtractNumbers(double NumberA, double NumberB);

    /// <summary>
    /// Multiplying numbers
    /// </summary>
    /// <param name="NumberA"></param>
    /// <param name="NumberB"></param>
    /// <returns>NumberA * NumberB</returns>
    double MultiplyNumbers(double NumberA, double NumberB);

    /// <summary>
    /// Dividing numbers
    /// </summary>
    /// <param name="NumberA"></param>
    /// <param name="NumberB"></param>
    /// <returns>NumberA / NumberB</returns>
    double DivideNumbers(double NumberA, double NumberB);

    /// <summary>
    /// Times a number with itself the amount of times specified by NumberB
    /// </summary>
    /// <param name="NumberA"></param>
    /// <param name="NumberB"></param>
    /// <returns>NumberA ^ NumberB</returns>     
    public double Potency(double NumberA, double NumberB);
}