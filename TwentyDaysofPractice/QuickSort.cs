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
            // First assign a random value as the pivot value to avoid worst case hack
            // where the first havlue is at the extreme left or extreme right.
            // for larger arrays, it might be better to just select the middle element.
            // if a large number of elements, rather than selecting a random index just pick something in the middle.
            if (arr.Count >= 100000)
            {
                int median = arr.Count / 2;
                Swap(arr, 0, median);
            }
            else if (arr.Count > 1000 && arr.Count < 100000)
            {
                var first = arr[0];
                var second = arr[arr.Count / 2];
                var third = arr[arr.Count - 1];
                var median = 0;
                if (first > second && first < third)
                    median = 0;
                else if (second > first && second < third)
                    median = arr.Count / 2;
                else
                    median = arr.Count - 1;
                Swap(arr, 0, median);
            }
            else
            {
                // Assign a random value as the pivot value to avoid worst case hack
                // where the first havlue is at the extreme left or extreme right.
                var rand = new Random();
                var randIdx = rand.Next(arr.Count - 1);
                Swap(arr, 0, randIdx);
            }

            //Helper(arr, 0, arr.Count - 1);
            return arr;
        }


        public static void HelperHoares(List<int> arr, int start, int end)
        {
            if (start >= end)
                return;

            // Hoares Partitioning
            var smaller = start + 1;
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
                    bigger--;
                }
            }
            Swap(arr, start, bigger);

            HelperHoares(arr, start, bigger - 1);
            HelperHoares(arr, bigger + 1, end);

        }

        public static void HelperLomuto(List<int> arr, int start, int end)
        {
            if (start >= end)
                return;

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

            HelperLomuto(arr, start, smaller - 1);
            HelperLomuto(arr, smaller + 1, end);

            var x = new SortedDictionary<int, int>();
            //foreach (var item in x)
            //{
            //    item.v
            //}
        }

        public static void Swap(List<int> arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
