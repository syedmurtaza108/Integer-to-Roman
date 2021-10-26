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
            Console.WriteLine(IntToRoman(1994));
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
            answer += AddChar(thousand, 1000, 0);
            answer += AddChar(hundred >= 5 ? hundred / 5 : hundred, hundred >= 5 ? 500 : 100, hundred * 100);
            answer += AddChar(hundred != 4 && hundred != 9 && hundred >= 5 ? hundred % 5 : 0, 100, 0);
            answer += AddChar(ten >= 5 ? ten / 5 : ten, ten >= 5 ? 50 : 10, ten * 10);
            answer += AddChar(ten != 4 && ten != 9 && ten >= 5 ? ten % 5 : 0, 10, 0);
            answer += AddChar(num >= 5 ? num / 5 : num, num >= 5 ? 5 : 1, num);
            answer += AddChar(num != 4 && num != 9 && num >= 5 ? num % 5 : 0, 1, 0);
            return answer;
        }

        static string AddChar(int times, int key, int num)
        {
            string answer = "";
            switch (num)
            {
                case 4:
                    return "IV";
                case 9:
                    return "IX";
                case 40:
                    return "XL";
                case 90:
                    return "XC";
                case 400:
                    return "CD";
                case 900:
                    return "CM";
                default:
                    break;
            }
            for (int i = 0; i < times; i++)
            {
                answer += roman[key];
            }
            return answer;
        }
    }
}
