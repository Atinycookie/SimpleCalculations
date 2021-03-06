﻿ using System;
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
            //variables
            string calcType;
            double num1, num2;
            bool result = false;

            Console.WriteLine("What's the first number? ");
            while(!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error: NaN - Try again");
            }

            Console.WriteLine("\nWhat's the second number? ");
            while(!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error: NaN - Try again");
            }

            Console.WriteLine("\nWhat should I do with the numbers? Write +, -, / or *");
            while (!result)
            {
                calcType = Console.ReadLine();
                switch (calcType)
                {
                    case "+":
                        {
                            Console.WriteLine("The result is: " + (num1 + num2));
                            result = true;
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("The result is: " + (num1 - num2));
                            result = true;
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("The result is: " + (num1 * num2));
                            result = true;
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("The result is: " + (num1 / num2));
                            result = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("The calculation method you specified is invalid or not supported, please write something like: +, -, / or *");
                            break;
                        }
                }

            }
            Console.ReadKey();
        }
    }
}
