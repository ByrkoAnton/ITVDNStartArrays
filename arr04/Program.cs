using System;

namespace arr04
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

            arr = IncreaseCapacity(arr);
            ShowArr(arr);

            arr = PushFront(arr,33);
            ShowArr(arr);
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
        static int[] IncreaseCapacity(int[]arr)
        {
            int[] arrNew = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                arrNew[i] = arr[i];
            }
            arr = arrNew;
            return arr;
        }
        static int[] PushFront(int[]arr, int val)
        {
            arr = IncreaseCapacity(arr);
            for (int i = arr.Length-2; i > 0; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[0] = val;
            return arr;
        }
    }
}
