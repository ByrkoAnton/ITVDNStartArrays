using System;
using System.Linq;

namespace arr03
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

            arr = ArrRev(arr);
            ShowArr(arr);

            int[] arr2 = GetArrPart(arr, 4, 30);
            ShowArr(arr2);
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
        static int[] ArrRev(int[]arr)
        {
            int a = 0;
            int b = arr.Length-1;

            while (a<b)
            {
                int tmp = arr[a];
                arr[a] = arr[b];
                arr[b] = tmp;
                a++;
                b--;
            }
            return arr;
        }
        static int[] GetArrPart(int[] arr, int from, int to)
        {
            if(from>to)
            {
                Console.WriteLine("from can't be > to, will return all arr");
                return arr;
            }

            int n = to - from;
            int[] arrNew = new int[n];
            int curentElem = from;

            for (int i = 0; i < arrNew.Length; i++)
            {
                if (curentElem < arr.Length)
                    arrNew[i] = arr[curentElem++];
                else
                    arrNew[i] = 1;
            }
            return arrNew;
        }
    }
}
