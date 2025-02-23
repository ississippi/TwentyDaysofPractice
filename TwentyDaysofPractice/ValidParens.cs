using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwentyDaysofPractice
{
    internal class ValidParens
    {
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
        // determine if the input string is valid.
        // An input string is valid if:
        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.
        // Every close bracket has a corresponding open bracket of the same type.
        // Example 1:
        // Input: s = "()"
        // Output: true
        // Example 2:
        // Input: s = "()[]{}"
        // Output: true
        // Example 3:
        // Input: s = "(]"
        // Output: false
        // Example 4:
        // Input: s = "([])"
        // Output: true    

        public bool IsValid(string s)
        {
            var d = new Dictionary<char, char>
            {
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };
            var o = new Stack<char>();

            foreach (char c in s.ToCharArray())
            {
                if (d.Keys.Contains(c))
                    o.Push(c);
                else
                {
                    if (o.Count == 0)
                        return false;
                    var open = o.Pop();
                    if (d[open] != c)
                        return false;
                }
            }
            return (o.Count == 0);
        }
    }
}
