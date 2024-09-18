namespace csharpcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string? value;
            
                do
                {
            
                

                    try{
                        double Results;
                    
                        Console.Write("Enter first number:");
                        double NumberA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter method(+, -, *, / or ^):");
                        string? CalculationMethod = Console.ReadLine();
                        Console.Write("Enter second number:");
                        double NumberB = Convert.ToDouble(Console.ReadLine());
                    
    
                        switch (CalculationMethod)
                        {
                            case "+":
                                Results = NumberA + NumberB;
                                Console.WriteLine(NumberA + CalculationMethod + NumberB + "=" + Results);
                                break;
                            case "-":
                                Results = NumberA - NumberB;
                                Console.WriteLine(NumberA + CalculationMethod + NumberB + "=" + Results);
                                break;
                            case "*":
                                Results = NumberA * NumberB;
                                Console.WriteLine(NumberA + CalculationMethod + NumberB + "=" + Results);
                                break;
                            case "/":
                                Results = NumberA / NumberB;
                                Console.WriteLine(NumberA + CalculationMethod + NumberB + "=" + Results);
                                break;
                            case "^":
                                Results = Math.Pow(NumberA, NumberB);
                                Console.WriteLine(NumberA + CalculationMethod + NumberB + "=" + Results);
                                break;

                            default:
                                Console.WriteLine("incorrect input for method, use +, -, *, / or ^");
                                break;
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("input must be a number");
                    }
                        Console.Write("Do you want to continue(y/n):");
                        value = Console.ReadLine();
                }
                while (value=="y" || value=="Y");
                }
            
        }
    }
 
