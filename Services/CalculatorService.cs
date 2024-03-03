
using System.Linq.Expressions;

namespace Services
{
    public class CalculatorService
    {
        public void Calculation()
        {
            int num1, num2;
            char symbol;
            Console.WriteLine("Enter the first number:");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input for num1. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input for num2. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter the arithmetic operator (+, -, *, /):");
            char[] symbolArray = Console.ReadLine().ToCharArray();
            if (symbolArray.Length != 1 || !"+-*/".Contains(symbolArray[0]))
            {
                Console.WriteLine("Invalid input for the operator. Please enter a valid operator.");
                return;
            }
            symbol = symbolArray[0];

            switch (symbol)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + ((double)num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
