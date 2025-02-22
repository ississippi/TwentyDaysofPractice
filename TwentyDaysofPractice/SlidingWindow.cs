using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Drawing;
    using System.Xml.Linq;

    class SlidingWindowExample
    {
        // How It Works:
        // Computes the sum of the first window of size windowSize.
        // Iterates through the array while adjusting the sum:
        // Adds the new element entering the window.
        // Subtracts the element that is sliding out of the window.
        // Prints the sum of each window.
        public static void SlidingWindowTraverse(int[] arr, int windowSize)
        {
            if (arr.Length < windowSize || windowSize <= 0)
            {
                Console.WriteLine("Invalid window size.");
                return;
            }

            int windowSum = 0;

            // Compute the sum of the first window
            for (int i = 0; i < windowSize; i++)
            {
                windowSum += arr[i];
            }
            Console.WriteLine($"Window 1: Sum = {windowSum}");

            // Slide the window across the array
            for (int i = windowSize; i < arr.Length; i++)
            {
                // Add next element and remove the first element of the previous window
                windowSum += arr[i] - arr[i - windowSize]; 
                Console.WriteLine($"Window {i - windowSize + 2}: Sum = {windowSum}");
            }
        }

    }

}
