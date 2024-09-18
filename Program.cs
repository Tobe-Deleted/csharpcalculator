using System;
using System.Text;
using System.Threading.Tasks;
 
namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                double res;
                Console.Write("Enter first number:");
                double NumberA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
                Console.Write("Enter second number:");
                double NumberB = Convert.ToInt32(Console.ReadLine());
                
 
                switch (symbol)
                {
                    case "+":
                        res = NumberA + NumberB;
                        Console.WriteLine(NumberA + symbol + NumberB + "=" + res);
                        break;
                    case "-":
                        res = NumberA - NumberB;
                        Console.WriteLine(NumberA + symbol + NumberB + "=" + res);
                        break;
                    case "*":
                        res = NumberA * NumberB;
                        Console.WriteLine(NumberA + symbol + NumberB + "=" + res);
                        break;
                    case "/":
                        res = NumberA / NumberB;
                        Console.WriteLine(NumberA + symbol + NumberB + "=" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");
        }
    }
 
}