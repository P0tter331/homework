using System;

namespace Homework4
{
    internal class IsMatrix
    {
        static bool JudgeMatrix(int[,] matrix)
        {
            if (matrix == null) { return false; }
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            //不遍历完所有行和列
            for (int i = 0; i < m-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (matrix[i,j] != matrix[i +1,j+1]) 
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the row of the array");
            int m=int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the col of  the array");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[m,n];
            //一直读取直到输入空行
            Console.WriteLine("please enter element by element");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"元素 [{i + 1}, {j + 1}]:");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }


/*            foreach (int i in array)
            {
                Console.WriteLine(i);
            }*/


            Console.WriteLine(JudgeMatrix(array));
        }
    }
}
