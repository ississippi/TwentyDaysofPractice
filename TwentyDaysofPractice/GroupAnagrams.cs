using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var res = new List<IList<string>>();
            var used = new HashSet<string>();

            for (int i = 0; i < strs.Length; i++)
            {
                var ls = new List<string>();
                if (!used.Contains(strs[i]))
                {
                    used.Add(strs[i]);
                    ls.Add(strs[i]);
                    for (int j = i+1; j < strs.Length; j++)
                    {
                        if (HasSameLetters(strs[i], strs[j]))
                        {
                            if (!used.Contains(strs[j]))
                            {
                                used.Add(strs[j]);
                                ls.Add(strs[j]);
                            }
                        }
                    }
                }
                if (ls.Count > 0)
                    res.Add(ls);
            }

            return res;
        }

        public bool HasSameLetters(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            foreach (char c in str1.ToCharArray())
            {
                if (!str2.Contains(c))
                    return false;
            }
            return true;

        }

    }
}
