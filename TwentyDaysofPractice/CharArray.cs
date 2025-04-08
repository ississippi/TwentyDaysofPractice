using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    class CharArray
    {
        public static bool IsAlpha(string s)
        {
            int a = (int)'a';
            int z = (int)'z';
            int A = (int)'A';
            int Z = (int)'Z';

            var arr = s.ToCharArray();
            foreach(var c in arr)
            {
                var cint = (int)c;
                if (!(c >= a && c <= z) && !(c >= A && c <= Z))
                    return false;
            }

            return true;
        }
    }
}
