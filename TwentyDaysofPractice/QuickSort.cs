using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class QuickSort
    {
        public static List<int> quick_sort(List<int> arr)
        {
            // Write your code here.
            Helper(arr, 0, arr.Count - 1);
            return arr;
        }


        public static void Helper(List<int> arr, int start, int end)
        {
            if (start >= end)
                return;

            // Lomutos Partitioning
            var smaller = start;
            for (int bigger = start + 1; bigger <= end; bigger++)
            {
                if (arr[bigger] < arr[start])
                {
                    smaller++;
                    Swap(arr, smaller, bigger);
                }

            }
            Swap(arr, start, smaller);

            Helper(arr, start, smaller - 1);
            Helper(arr, smaller + 1, end);


        }

        public static void Swap(List<int> arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void HelperHoares(List<int> arr, int start, int end)
        {
            if (start >= end)
                return;

            // Hoares Partitioning
            var smaller = start;
            var bigger = end;

            while (smaller <= bigger)
            {
                if (arr[smaller] < arr[start])
                    smaller++;
                else if (arr[bigger] > arr[start])
                    bigger--;
                else
                {
                    Swap(arr, smaller, bigger);
                    smaller++;
                }
            }
            Swap(arr, start, bigger);
        }
    }
}
