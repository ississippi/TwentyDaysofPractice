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
            var rand = new Random();
            var randIdx = rand.Next(arr.Count - 1);
            Console.WriteLine($"1st before: {arr[0]}");
            Swap(arr, 0, randIdx);
            Console.WriteLine($"1st after: {arr[0]}");
            HelperHoares(arr, 0, arr.Count - 1);
            //HelperLomuto(arr, 0, arr.Count - 1);
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


        }

        public static void Swap(List<int> arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
