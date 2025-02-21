using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
        // Given a string s and an integer k, reverse the first k characters for every 2k characters counting
        // from the start of the string.
        // If there are fewer than k characters left, reverse all of them.If there are less than 2k but
        // greater than or equal to k characters, then reverse the first k characters and leave the other as original.
        // Example 1:
        // Input: s = "abcdefg", k = 2
        // Output: "bacdfeg"
        // Example 2:
        // Input: s = "abcd", k = 2
        // Output: "bacd"    
        //internal class ReverseStringII
        //{
        //    public string ReverseStr(string s, int k)
        //    {
        //        int left = 0;
        //        int right = s.Length - 1;
        //        while (left < right)
        //        {
        //            char temp = s[left];
        //            s[left] = s[right];
        //            s[right] = temp;
        //            left++;
        //            right--;
        //        }
        //        Thread.Sleep(1000);
        //        Debug.WriteLine("\n==========================");
        //        Debug.WriteLine("Reversed string is: ");
        //        foreach (char c in s)
        //        {
        //            Debug.Write(c);
        //        }
        //        Debug.WriteLine("\n==========================\n");
        //}
}
