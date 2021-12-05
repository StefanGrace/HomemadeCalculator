using System;

namespace HomemadeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("0 - Exit\n" +
                    "1 - Add\n" +
                    "2 - Minus\n" +
                    "3 - Multiply\n" +
                    "4 - Divide\n" +
                    "5 - Power");
                Console.Write("Enter choice: ");
                choice = Console.ReadLine();

                int a = 0;
                int b = 0;
                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        try
                        {
                            Console.Write("Enter first number: ");
                            a = int.Parse(Console.ReadLine());
                            if (a < 0)
                            {
                                Console.WriteLine("Can't do negatives");
                                choice = "E";
                                break;
                            }
                            Console.Write("Enter second number: ");
                            b = int.Parse(Console.ReadLine());
                            if (b < 0)
                            {
                                Console.WriteLine("Can't do negatives");
                                choice = "E";
                                break;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Must enter an integer");
                            choice = "E";
                        }
                        break;
                }
                
                Calculator calc = new Calculator();
                int result = 0;

                switch (choice)
                {
                    case "E": break;
                    case "0": Console.WriteLine("Goodbye");  break;
                    case "1": result = calc.add(a, b); break;
                    case "2": result = calc.minus(a, b); break;
                    case "3": result = calc.multiply(a, b); break;
                    case "4": result = calc.divide(a, b); break;
                    case "5": result = calc.power(a, b); break;
                    default: Console.WriteLine("Invalid choice: " + choice); break;
                }

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.WriteLine("Result: " + result);
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}
