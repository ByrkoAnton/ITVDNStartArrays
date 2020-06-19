using System;

namespace arr02
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("enter array size ");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            FeelArrRnd(arr);
            ShowArr(arr);
            Console.WriteLine($"max={GetMax(arr)}");
            Console.WriteLine($"min={GetMin(arr)}");
            Console.WriteLine($"sum={GetSumAllElem(arr)}");
            Console.WriteLine($"averege={GetAveg(arr)}");
            Console.Write("odd values"  ); 
            ShowOdd(arr);
        }
        static void FeelArrRnd(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 100);
            }
        }
        static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static int GetSumAllElem(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }
        static double GetAveg(int[] arr)
        {
            return GetSumAllElem(arr)/(double)arr.Length;
        }
        static void ShowOdd(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2!=0)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
