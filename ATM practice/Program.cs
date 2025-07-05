using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n Simple Calculator\n");


                try
                {
                    Console.Write("Enter Firstnumber :");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Operator (+,-,*,/ :");
                    string op = Console.ReadLine();
                    Console.Write("Enter Secondnumber :");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;
                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine("Added successfully");
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine("Subtracted successfully");
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine("Multiplied successfully");
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("Divided successfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                                continue;
                            }
                            
                        default:
                            Console.WriteLine("Invalid operator");
                            continue;

                    }

                    Console.WriteLine($"Result:{num1}{op}{num2}={result}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                    continue;
                }

                Console.WriteLine("\n Do you want to calculate again?  y/n \n");
                string choice = Console.ReadLine();
                if (choice != "y")
                {
                    Console.WriteLine("Thank you for using atm ");
                    break;
                }
            }


        }

    }
}
