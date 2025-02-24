using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwentyDaysofPractice
{
    // You are given two arrays (without duplicates):nums1andnums2wherenums1’s elements are subset ofnums2.
    // Find all the next greater numbers fornums1's elements in the corresponding places ofnums2.
    // The Next Greater Number of a numberxinnums1is the first greater number to its right innums2.
    // If it does not exist, output-1 for this number.
    internal class NextGreaterElement
    {
        // My brute-force solution.
        // See "Approach 3: Using Stack" in Leetcode.
        // https://leetcode.com/problems/next-greater-element-i/solutions/127611/next-greater-element-i/
        public int[] NextGreater(int[] nums1, int[] nums2)
        {
            var intArr = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        var intArrLen = intArr.Count;
                        for (int k = j; k < nums2.Length; k++)
                        {
                            if (nums1[i] < nums2[k])
                            {
                                intArr.Add(nums2[k]);
                                break;
                            }
                        }
                        if (intArrLen == intArr.Count)
                            intArr.Add(-1);
                    }
                }
            }
            return intArr.ToArray();
        }
    }
}
