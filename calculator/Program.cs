using System;
using CalculatorLibrary1;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console calculator in c#\r");
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                string N1 = "";
                string N2 = "";
                double result = 0;

                Console.Write("Enter first number and then press Enter Key: ");
             N1 = Console.ReadLine();

                double cleanN1 = 0;
                while (!double.TryParse(N1, out cleanN1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    N1 = Console.ReadLine();
                }

                Console.Write("Enter second number and then press Enter Key: ");
                N2 = Console.ReadLine();

                double cleanN2 = 0;
                while (!double.TryParse(N2, out cleanN2))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    N2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an mathematical operator from the list below:");
                Console.WriteLine("\tAddition       - +");
                Console.WriteLine("\tSubtraction    - -");
                Console.WriteLine("\tMultiplication - *");
                Console.WriteLine("\t Divide        - /");
                Console.WriteLine("Type your option");

                string op = Console.ReadLine();

                try
                {
                    Calculator cal = new Calculator();
                    result = cal.DoOperation(cleanN1, cleanN2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

            
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }

            return;
        }
    }
}