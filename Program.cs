namespace csharpcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();
            string? value;
            
                do
                {
                    bool ValidNumber = false;
                    string? CalculationMethod = "0";
                    double NumberA = double.NaN;
                    double NumberB = 0;
                    
                    while (!ValidNumber)
                    {
                        
                        try
                        {
                            Console.Write("Enter first number:");
                            NumberA = Convert.ToDouble(Console.ReadLine());
                            ValidNumber = true;
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("input must be a number");
                            ValidNumber = false;
                        }
                    }
                    
                    while (ValidNumber)
                    {
                        Console.Write("Enter operation(+, -, *, / or ^):");
                        CalculationMethod = Console.ReadLine();
                        if (CalculationMethod == "+" || CalculationMethod == "-" || CalculationMethod == "*" || CalculationMethod == "/" || CalculationMethod == "^")
                        ValidNumber = false;
                    }
                    
                    while (!ValidNumber)
                    {
                        
                        try
                        {
                            Console.Write("Enter second number:");
                            NumberB = Convert.ToDouble(Console.ReadLine());
                            ValidNumber = true;
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("input must be a number");
                            ValidNumber = false;
                        }
                    }

                        switch (CalculationMethod)
                        {
                            case "+":
                                Console.WriteLine($"{NumberA} + {NumberB} = {calculator.AddNumbers(NumberA, NumberB)}");
                                break;
                            case "-":
                                Console.WriteLine($"{NumberA} - {NumberB} = {calculator.SubtractNumbers(NumberA, NumberB)}");
                                break;
                            case "*":
                                Console.WriteLine($"{NumberA} * {NumberB} = {calculator.MultiplyNumbers(NumberA, NumberB)}");
                                break;
                            case "/":
                                Console.WriteLine($"{NumberA} / {NumberB} = {calculator.DivideNumbers(NumberA, NumberB)}");
                                break;
                            case "^":
                                Console.WriteLine($"{NumberA} ^ {NumberB} = {calculator.Potency(NumberA, NumberB)}");
                                break;

                            default:
                                Console.Write("operation is not +, -, *, / or ^ :");
                                break;
                        }
                    

                        Console.Write("Do you want to continue(y/n):");
                        value = Console.ReadLine();
                }
                while (value=="y" || value=="Y");
                }
            
        }
    }
 
