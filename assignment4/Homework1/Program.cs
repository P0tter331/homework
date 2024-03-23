using System;

namespace Homework1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("please input your number to the list(input 'exit' to quit)");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                try
                {
                    list.Add(int.Parse(input));
                }
                catch
                {
                    Console.WriteLine("invalid input!please input your number to the list(input 'exit' to quit)");
                }
            }
            Console.WriteLine("input is over.");
            list.ForEach(n => Console.WriteLine(n));
            int max = list[0] ;
            int min = max;
            int sum = 0;

            list.ForEach(n =>
            {
                if (max < n)
                {
                    max = n;
                }
            });
            Console.WriteLine($"max={max}");

            list.ForEach(n =>
            {
                if (min > n)
                {
                    min = n;
                }
            });
            Console.WriteLine($"min={min}");

            list.ForEach(n=>sum += n);
            Console.WriteLine($"sum={sum}");

        }
    }
}
