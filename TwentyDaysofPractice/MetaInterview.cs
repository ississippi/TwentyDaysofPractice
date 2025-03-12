using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    class MetaInterview
    {
        public bool IsPalindrome(string input)
        {
            // Given a string S consisting of lowercase English characters, determine if you can make it a palindrome by removing at most 1 character.

            // racecar -> true
            // bracecar -> true
            // racecarbf -> false

            // tacocats --> True  # tacocats --> tacocat
            // racercar --> True  # racercar --> racecar, racrcar
            // kbayak --> True  # kbayak --> kayak 
            // acbccba --> True # acbccba --> abccba
            // abccbca --> True # abccbca --> abccba

            // abcd --> False
            // btnnure --> False
            // baaba -> baab -> true
            // aaba false

            //left = 0;
            //right = str.ToArray();
            //int mismatchCount = 0;
            //while(str[left] != str[right])
            //{
            //    if (str[left] == str[right])
            //    {
            //        right--;
            //        left++;
            //        continue;
            //    }
            //    else
            //    {
            //        if (str[left + 1] == str[right])
            //        {
            //            left++;

            //        }
            //    }
            //}
            return false;
        }

        public int LocalMinimum(int[] input)
        {
            //Given an array of integers, find any one local minimum from the array. A local minimum is defined as an integer in the array that is less than or equal to its neighbors.

            // [5, 9, 7, 10, 12]  => 5,7

            // [1,1,1,1] => 1,1,1,1

            // [10,9,8,7,6] => 6

            // [5, 13, 12, 9, 12]

            // case 1: the mid point is the local min
            // case 2: a < b < c where you go to side c
            // case 3: a < b > c what do you do?

            //int left = 0;
            //int right = arr.Length - 1;
            //int mid = right - left / 2;

            //While(left < right)
            //{
            //    int mid = right - left / 2;
            //    if (arr[mid + 1] > arr[mid] && arr[mid - 1] > arr[mid])
            //    {
            //        return arr[mid];
            //    }
            //    else if (arr[mid] > arr[mid - 1] && arr[mid + 1] > arr[mid])
            //    {
            //        left = mid + 1;
            //    }
            //    else
            //    {
            //        right = mid;
            //    }
            //}
            return -1;
        }
    }
}
