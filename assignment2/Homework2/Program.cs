using System;

namespace Homework2
{
    internal class ArrayCalculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input the elements delimited by Spaces");
            string input = Console.ReadLine();
            //将输入的字符串拆分为数组元素
            string[] inputSplit = input.Split(" ");
            int[] array = new int[inputSplit.Length];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = int.Parse(inputSplit[i]);
            }
            int max=array[0];
            for (int i = 1; i < array.Length; i++) 
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average=sum/array.Length;
            Console.WriteLine($"max ={max}\nmin={min}\naverage={average}\nsum={sum}");
        }
    }
}
