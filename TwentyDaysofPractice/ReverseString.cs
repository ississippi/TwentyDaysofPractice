using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwentyDaysofPractice
{
    // Write a function that reverses a string. The input string is given as an array of characters s.
    //    You must do this by modifying the input array in-place with O(1) extra memory.
    // Example 1:
    // Input: s = ["h", "e", "l", "l", "o"]
    // Output: ["o", "l", "l", "e", "h"]
    // Example 2:
    // Input: s = ["H", "a", "n", "n", "a", "h"]
    //Output: ["h", "a", "n", "n", "a", "H"]
    internal class ReverseString
    {
        public void ReverseStr(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            Thread.Sleep(1000);
            Debug.WriteLine("\n==========================");
            Debug.WriteLine("Reversed string is: ");
            foreach (char c in s)
            {
                Debug.Write(c);
            }
            Debug.WriteLine("\n==========================\n");
        }
    }
}
