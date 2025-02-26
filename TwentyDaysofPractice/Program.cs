// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Threading.Tasks;

using TwentyDaysofPractice;

//char[] s = ['h', 'e', 'l', 'l', 'o'];
//var rsI = new ReverseString();
//rsI.ReverseStr(s);

//var rsI = "abcdefg";
//var rsII = new ReverseStringII();
//var reved = rsII.ReverseStr(rsI, 2);
//Debug.WriteLine("\n==========================");
//Debug.WriteLine("Reversed string is: ");
//foreach (char c in reved)
//{
//    Debug.Write(c);
//}
//Debug.WriteLine("\n==========================\n");

//var ip1 = "A man, a plan, a canal: Panama";
//var p = new Palindrome();
//Debug.WriteLine($"isPalindrone: {p.IsPalindrome(ip1)}");

//var list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
//var list2 = new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
//var m = new MinIdxSumTwoLists();
//var res = m.FindRestaurant(list1, list2);
//Debug.WriteLine("Restaurants with minimum index sum are: ");
//Thread.Sleep(1000);
//foreach (string s in res)
//{
//    Debug.WriteLine(s);
//}

//var s = "abcabcbb";
//var s = " ";
//var s = "aab";
//var s = "dvdf";
//var l = new LongestSubstring();
//Debug.WriteLine($"Longest substring without repeating characters is: {l.LengthOfLongestSubstring(s)}");

//var l = new LinkedList("Gary");
//l.Append("Smith");
//Debug.WriteLine(l.head.value);
//Debug.WriteLine(l.head.next.value);

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int windowSize = 3;
//Console.WriteLine("Sliding Window Sum:");
//SlidingWindowExample.SlidingWindowTraverse(arr, windowSize);

//string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
string[] arr = {"", ""};
var g = new GroupAnagramsClass();
var res = g.GroupAnagrams(arr);
Debug.Write(res);
