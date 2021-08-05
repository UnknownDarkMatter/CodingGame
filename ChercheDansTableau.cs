using System;

namespace ChercheDansTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr; ;
            arr = new int[] { -9, 14, 37, 102 };
            bool contains = Contains(arr, 102);
            Console.WriteLine(contains);
            contains = Contains(arr, -9);
            Console.WriteLine(contains);
            contains = Contains(arr, 36);
            Console.WriteLine(contains);
            arr = new int[] { 2, 3, 10, 11, 12, 18, 20, 30, 35, 40, 46, 50, 100, 120 };
            contains = Contains(arr, 101);
            Console.WriteLine(contains);
            arr = new int[] { 2, 3, 10, 11, 12, 18, 20, 30, 35, 40, 46, 50, 100, 120, 150, 200, 201, 210, 250, 280, 300, 340 };
            contains = Contains(arr, 201);
            Console.WriteLine(contains);
            contains = Contains(arr, 211);
            Console.WriteLine(contains);
            arr = new int[] {  };
            contains = Contains(arr, 101);
            Console.WriteLine(contains);

            Console.ReadLine();
        }

        public static bool Contains(int[] arr, int k)
        {
            if(arr is null || arr.Length == 0) { return false; }

            bool apresIndex = true;
            int min = 0;
            int max = arr.Length - 1;
            int index = 0;
            while (true)
            {
                if (apresIndex)
                {
                    min = (index == min && index > 0) ? index + 1 : index;
                } else
                {
                    max = index == max ? index - 1 : index;
                }
                index = min + (max - min) / 2;
                var value = arr[index];
                if(value == k)
                {
                    return true;
                }
                if (min >= max) { return false; }
                apresIndex = value < k;
            }
            return false;
        }
    }
}
