﻿using System;
using System.Text.RegularExpressions;

namespace RegexSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "1, 1000, 1 000 000, 100.23";
            string input2 = "http://ya.ru/api?r=1&x=23";
            string input3 = "";
            string[] values = new[] { "123", "+373 77767852", "3333", "77767852", "0 (777) 67852", "-33377088" };

            string pattern1 = @"\b100\.\d{2}|10{3}|(1 0{3} 0{3})|1\b";
            string pattern2 = @"(?<=api\?)\S+?(?=&)|(?<=&)\S+?(?=&)|(?<=&)\S+";
            string pattern3 = "";
            string pattern4 = "";

            Console.WriteLine(input1);
            MatchCollection matchCollection = Regex.Matches(input1, pattern1);
            foreach (Match match in matchCollection)
            {
                Console.WriteLine("{0}' found at position {1}.", match.Value, match.Index);
            }
            
            Console.WriteLine(input2);
            foreach (Match match in Regex.Matches(input2, pattern2))
            {
                Console.WriteLine("{0}' found at position {1}.", match.Value, match.Index);
            }

        }
    }
}