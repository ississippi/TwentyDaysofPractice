// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

using TwentyDaysofPractice;

//char[] s = ['h', 'e', 'l', 'l', 'o'];
//var rsI = new ReverseString();
//rsI.ReverseStr(s);

var rsI = "abcdefg";
var rsII = new ReverseStringII();
var reved = rsII.ReverseStr(rsI, 2);
Debug.WriteLine("\n==========================");
Debug.WriteLine("Reversed string is: ");
foreach (char c in reved)
{
    Debug.Write(c);
}
Debug.WriteLine("\n==========================\n");

//var ip1 = "A man, a plan, a canal: Panama";
//var p = new Palindrome();
//Debug.WriteLine($"isPalindrone: {p.IsPalindrome(ip1)}");
