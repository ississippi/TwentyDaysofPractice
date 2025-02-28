using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class MergeSortClass
    {

        public static List<int> merge_sort(List<int> arr)
        {
            // Write your code here.
            var aux = new List<int>(arr.Count);
            for (int i = 0; i < arr.Count; i++)
            {
                aux.Add(0);
            }
            MergeSort(arr, aux, 0, arr.Count - 1);
            return arr;
        }

        public static void MergeSort(List<int> arr, List<int> aux, int start, int end)
        {
            if (start < end)
            {
                var mid = (start + end) / 2;
                //Console.WriteLine($"MergeSort1: start: {start}, end: {end}");
                MergeSort(arr, aux, start, mid);
                //Console.WriteLine($"MergeSort2: arr.Count: {arr.Count}, aux.Count: {aux.Count}, start: {start}, mid+1: {mid+1}, end: {end}");
                MergeSort(arr, aux, mid + 1, end);
                //Console.WriteLine($"Merge: start: {start}, end: {end}");
                Merge(arr, aux, start, mid, end);
            }
        }

        public static void Merge(List<int> arr, List<int> aux, int start, int mid, int end)
        {
            //Console.WriteLine($"Merge: arr.Count: {arr.Count}, aux.Count: {aux.Count}, start: {start}, mid: {mid}, end: {end}");
            for (int i = start; i <= end; i++)
            {
                aux[i] = arr[i];
            }
            //Console.WriteLine($"Merge: aux.Count: {aux.Count}");

            var auxLeft = start;
            var auxRight = mid + 1;
            var current = start;

            //Console.WriteLine($"auxLeft: {auxLeft}, auxRight: {auxRight}, current: {current}");
            while (auxLeft <= mid && auxRight <= end)
            {
                if (aux[auxLeft] <= aux[auxRight])
                {
                    arr[current] = aux[auxLeft];
                    auxLeft++;
                }
                else
                {
                    arr[current] = aux[auxRight];
                    auxRight++;
                }
                current++;
            }
            //Console.WriteLine($"Remaining: auxLeft: {auxLeft}, auxRight: {auxRight}, current: {current}");

            // Copy the rest of the left side into the target array
            var remaining = mid - auxLeft;
            //Console.WriteLine($"remaining: {remaining}");

            for (int i = 0; i <= remaining; i++)
            {
                arr[current + i] = aux[auxLeft + i];
            }

        }

    }
}
