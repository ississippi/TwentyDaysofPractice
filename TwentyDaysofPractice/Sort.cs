using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class SortClass
    {
        public static List<int> BubbleSort(List<int> arr)
        {
            // Write your code here.
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = arr.Count - 1; j >= i + 1; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static List<int> SelectionSort(List<int> arr)
        {
            // Write your code here.
            for (int i = 0; i < arr.Count; i++)
            {
                var minNum = arr[i];
                var minIdx = i;

                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < minNum)
                    {
                        minNum = arr[j];
                        minIdx = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIdx];
                arr[minIdx] = temp;
            }
            return new List<int>(arr);
        }

        public static List<int> InsertionSort(List<int> arr)
        {
            // Write your code here.
            for (int i = 0; i < arr.Count; i++)
            {
                var temp = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }

    }
}
