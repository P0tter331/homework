using System;
using System.Collections.Generic;

namespace Homework1
{   
     class FindPrim
    {
        static bool IsPrim(int n)
        {
            for (int i = 2; i*i <= n; i++)//利用i<根号n简化算法
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine( "please input your number to find its prim:");
            int num= int.Parse( Console.ReadLine() );
            List<int> result = new List<int>();
            bool flag= false;   //用来标识是否有素数因子
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    if (IsPrim(i))
                    {
                        result.Add(i);
                        flag = true;
                    }

                }
            }
            if (!flag) { Console.WriteLine("cannot find any prim factor"); }
            else
            {
                Console.WriteLine("the number's prim factor is:");
                foreach (var i in result)
                {
                    Console.WriteLine(i);
                }
            }
            

        }
    }
}
