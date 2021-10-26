using System;
using System.Collections.Generic;

namespace Integer_to_Roman
{
    class Program
    {
        static Dictionary<int, char> roman = new Dictionary<int, char>
        {
            { 1,'I'},
            { 5, 'V'},
            { 10, 'X'},
            { 50, 'L'},
            { 100, 'C'},
            { 500, 'D'},
            {1000, 'M'},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string IntToRoman(int num)
        {
            string answer = "";
            int thousand = num / 1000;
            num = num % 1000;
            int hundred = num / 100;
            num = num % 100;
            int ten = num / 10;
            num = num % 10;
            answer += AddChar(thousand, 1000);
            answer += AddChar(hundred >= 5 ? hundred / 5 : hundred, hundred >= 5 ? 500 : 100);
            return answer;
        }

        static string AddChar(int times, int key)
        {
            string answer = "";
            for (int i = 0; i < times; i++)
            {
                answer += roman[key];
            }
            return answer;
        }
    }
}
