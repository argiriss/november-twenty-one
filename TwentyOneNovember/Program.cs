using System;
using System.Collections.Generic;

namespace TwentyOneNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list3 = new List<double> { 1, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 1, 2, 2,2,2, 3, 4, 5, 6, };
            List<string> list = new List<string>{  "as", "as", "as", "as", "as", "ads"};
            Utilities.LongestSubsequence(list);

            Console.ReadKey();
        }
    }
}
