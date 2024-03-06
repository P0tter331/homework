using System;
using System.Collections.Generic;


namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();

            //创建辅助数组，默认全部是true
            bool[] isPrim=new bool[100+1];
            for(int i=2; i<isPrim.Length;i++)
            {
                isPrim[i] = true;
            }

            for (int i = 2; i*i < 101; i++)
            {
                if (isPrim[i]==true)
                {
                    for (int j = i * i; j < 101; j += i)
                        isPrim[j] = false;
                }
            }

            for(int i = 0; i < 101; i++)
            {
                if (isPrim[i] == true)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine("the prim in array is");
            foreach (int i in result) { Console.WriteLine(i); }
        }
    }
}
