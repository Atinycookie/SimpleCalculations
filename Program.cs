using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calcType;
            int num1, num2;

            Console.WriteLine("What's the first number? ");
            Int32.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("\nWhat's the second number? ");
            Int32.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("\nWhat should I do with the numbers? Write +, -, / or *");
            calcType = Console.ReadLine();

            switch (calcType)
            {
                case "+":
                    {
                        Console.WriteLine("The result is: " + (num1+num2));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("The result is: " + (num1 - num2));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("The result is: " + (num1 * num2));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("The result is: " + (num1 / num2));
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
