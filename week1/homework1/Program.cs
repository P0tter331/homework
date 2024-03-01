using System;
using System.Linq;

namespace homework1
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the first number:(type q to exit)");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
//              if (!input.All(char.IsDigit)) { Console.WriteLine("You should enter the number"); }
//              这里想尝试进行一些故障排除但失败了，不能用go to
                double a = Convert.ToDouble(input);

                Console.WriteLine("Please enter an operator:");
                string op = Console.ReadLine();

                Console.WriteLine("Please enter the second number:");
                double b = Convert.ToDouble(Console.ReadLine());

                double c = 0;

                switch (op)
                {
                    case "+":
                        c = a + b;
                        Console.WriteLine($"The result is {c}");
                        break;
                    case "-":
                        c = a - b;
                        Console.WriteLine($"The result is {c}");
                        break;
                    case "*":
                        c = a * b;
                        Console.WriteLine($"The result is {c}");
                        break;
                    case "/":
                        if (b != 0)
                        {
                            c = a / b;
                            Console.WriteLine($"The result is {c}");
                        }
                        else
                        {
                            Console.WriteLine("The divisor cannot be 0.");
                        }
                        break;

                    default:
                        Console.WriteLine("The operator you entered is incorrect.");
                        break;
                }
            }
            return;
        }
    }
}
