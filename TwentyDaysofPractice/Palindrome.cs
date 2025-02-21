using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;

            s = s.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsAsciiLetterOrDigit(c))
                    continue;
                sb.Append(c);
            }
            s = sb.ToString();
            //s = s.Replace(" ", string.Empty).Replace(",", string.Empty).Replace(",", string.Empty).Replace(":", string.Empty);
            var left = 0;
            var right = s.Length - 1;
            
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
