using System;
using System.Text.RegularExpressions;

namespace Consecutive_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.textTest("Ths wbst s fr lsrs LL!",Kata.Disemvowel("This website is for losers LOL!"));
            Tests.textTest("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd",Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
            Tests.textTest("Wht r y,  cmmnst?",Kata.Disemvowel("What are you, a communist?"));
        }
    }

    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "(?i)[aioue]", "");
        }
    }

    public static class Tests
    {
        public static void textTest(string a, string b) {
            if (a == b)
            {
                Console.WriteLine("Its correct!");
            }
            else
            {
                Console.WriteLine("Its incorrect!");
            }
        }
    }
}