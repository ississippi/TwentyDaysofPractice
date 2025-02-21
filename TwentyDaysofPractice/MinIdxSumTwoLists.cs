using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyDaysofPractice
{
    internal class MinIdxSumTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2) {
            var d = new Dictionary<string,int>();

            for(int i = 0; i < list1.Length; i++)
            {
                if (!d.ContainsKey(list1[i]))
                    d.Add(list1[i],i);
            }
            var lowestSum = Int32.MaxValue;
            var lowestStrArr = new List<string>();
            for(int i = 0; i < list2.Length; i++)
            {
                if (d.ContainsKey(list2[i]))
                {
                    d[list2[i]] += i;
                    int val = d[list2[i]];
                    if (val < lowestSum)
                    {
                        lowestSum = d[list2[i]];
                        lowestStrArr.Clear();
                        lowestStrArr.Add(list2[i]);
                    }
                    else if (val == lowestSum)
                    {
                        lowestStrArr.Add(list2[i]);
                    }
                }
            }    
            return lowestStrArr.ToArray();
        }

    }
}
