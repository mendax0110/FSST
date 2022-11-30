using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// make a user friendly menue for the calculator to choose from
namespace KW47_Berechnungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make a menue for the user to choose from
            Console.WriteLine("------------------------");
            Console.WriteLine("Choose a calculation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulo");
            Console.WriteLine("6. Exit");
            Console.WriteLine("------------------------");
            Console.Write("Enter your choice: ");

            // make a switch case for the user to choose from and make the calculation.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the first number: ");
                    Console.WriteLine("------------------------");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the second number: ");
                    Console.WriteLine("------------------------");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-------------------");
                    Console.WriteLine("The result is: " + (firstNumber + secondNumber));
                    Console.WriteLine("-------------------");
                    break;
                case "2":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the first number: ");
                    Console.WriteLine("------------------------");
                    double firstNumber1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the second number: ");
                    Console.WriteLine("------------------------");
                    double secondNumber1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-------------------");
                    Console.WriteLine("The result is: " + (firstNumber1 - secondNumber1));
                    Console.WriteLine("-------------------");
                    break;
                case "3":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the first number: ");
                    Console.WriteLine("------------------------");
                    double firstNumber2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the second number: ");
                    Console.WriteLine("------------------------");
                    double secondNumber2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-------------------");
                    Console.WriteLine("The result is: " + (firstNumber2 * secondNumber2));
                    Console.WriteLine("-------------------");
                    break;
                case "4":
                    // if divide by zero, show user the error message.
                    try
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Enter the first number: ");
                        Console.WriteLine("------------------------");
                        double firstNumber4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Enter the second number: ");
                        Console.WriteLine("------------------------");
                        double secondNumber4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("-------------------");
                        Console.WriteLine("The result is: " + (firstNumber4 % secondNumber4));
                        Console.WriteLine("-------------------");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You can't divide by zero!");
                    }

                    break;
                case "5":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the first number: ");
                    Console.WriteLine("------------------------");
                    double firstNumber5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Enter the second number: ");
                    Console.WriteLine("------------------------");
                    double secondNumber5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-------------------");
                    Console.WriteLine("The result is: " + (firstNumber5 % secondNumber5));
                    Console.WriteLine("-------------------");
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            // check if the user wants to continue or not
            Console.ReadLine();

            // if the user wants to do another calculation, the program will start again.
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Do you want to do another calculation? (y/n)");
            Console.WriteLine("--------------------------------------------");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Main(null);
            }
            else
            {
                // display a message to the user
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Thank you for using the calculator!");
                Console.WriteLine("-----------------------------------");
                // wait a few seconds before the program closes
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
