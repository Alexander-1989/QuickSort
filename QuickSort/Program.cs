using System;
using System.Collections;

namespace QuickSort
{
    class Program
    {
        static readonly Random random = new Random();

        public static void DisplayArray(IEnumerable items)
        {
            foreach (var value in items)
            {
                Console.Write($"[{value}] ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            const int Count = 16;

            int[] nums = new int[Count];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(-300, 300);
            }

            Console.WriteLine("Array before sorting:");
            DisplayArray(nums);

            Console.WriteLine("Sorting by ascending:");
            QuickSort.Sort(nums);
            DisplayArray(nums);

            Console.WriteLine("Sorting by Descending:");
            QuickSort.Sort(nums, QuickSort.SortType.Descending);
            DisplayArray(nums);

            char[] chrs = new char[Count];
            for (int j = 0; j < chrs.Length; j++)
            {
                chrs[j] = (char)('a' + random.Next(26));
            }

            Console.WriteLine("Array before sorting:");
            DisplayArray(chrs);

            Console.WriteLine("Sorting by ascending:");
            QuickSort.Sort(chrs, QuickSort.SortType.Ascending);
            DisplayArray(chrs);

            Console.WriteLine("Sorting by Descending:");
            QuickSort.Sort(chrs, QuickSort.SortType.Descending);
            DisplayArray(chrs);

            double[] doubleNums = new double[Count];
            for (int k = 0; k < doubleNums.Length; k++)
            {
                double div = random.Next(-300, 300);
                double mod = Math.Round(random.NextDouble(), 2);
                doubleNums[k] = div + mod;
            }

            Console.WriteLine("Array before sorting:");
            DisplayArray(doubleNums);

            Console.WriteLine("Sorting by ascending:");
            QuickSort.Sort(doubleNums);
            DisplayArray(doubleNums);

            Console.WriteLine("Sorting by Descending:");
            QuickSort.Sort(doubleNums, QuickSort.SortType.Descending);
            DisplayArray(doubleNums);

            Console.ReadKey();
        }
    }
}