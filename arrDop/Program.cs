using System;

namespace arrDop
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
            ShowArrRev(arr);
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

        static void ShowArrRev(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
