using System;

namespace QuickSort
{
    static class QuickSort
    {
        public enum SortType
        {
            Ascending,
            Descending
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        private static int Compare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        private static void SortArray<T>(T[] array, int first, int last, int direction) where T : IComparable<T>
        {
            int start = first;
            int end = last;
            int middle = start + ((end - start) / 2);
            T pivot = array[middle];

            while (start <= end)
            {
                while (direction * Compare(array[start], pivot) < 0)
                {
                    start++;
                }

                while (direction * Compare(array[end], pivot) > 0)
                {
                    end--;
                }

                if (start <= end)
                {
                    Swap(ref array[start], ref array[end]);
                    start++;
                    end--;
                }
            }

            if (first < end)
            {
                SortArray(array, first, end, direction);
            }

            if (start < last)
            {
                SortArray(array, start, last, direction);
            }
        }

        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            Sort(array, SortType.Ascending);
        }

        public static void Sort<T>(T[] array, SortType sorting) where T : IComparable<T>
        {
            if (array != null && array.Length > 1)
            {
                int first = 0;
                int last = array.Length - 1;
                int direction = (sorting == SortType.Ascending) ? 1 : -1;
                SortArray(array, first, last, direction);
            }
        }
    }
}