// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

using TwentyDaysofPractice;

//char[] s = ['h', 'e', 'l', 'l', 'o'];
//var rsI = new ReverseString();
//rsI.ReverseStr(s);

//var rsII = new ReverseStringII();
//rsII.ReverseStr("abcdefg", 2);

var ip1 = "A man, a plan, a canal: Panama";
var p = new Palindrome();
Debug.WriteLine($"isPalindrone: {p.IsPalindrome(ip1)}");
