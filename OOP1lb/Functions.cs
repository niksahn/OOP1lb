﻿using System.Text.RegularExpressions;

namespace OOP1lb
{
    internal static class Functions
    {
        internal static string RandomString()
        {
            Random rnd = new Random();
            Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string result = String.Empty;
            for (int i = 0; i < 10; i++)
                result += pwdChars[rnd.Next(0, 25)];
            return result;
        }

        internal static bool IsString(string str)
        {
            string pattern = @"^[A-Za-zА-Яа-я]([A-Za-zА-Яа-я]|[1-9])*$";
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                return match.Success;
            }
            return false;
        }

        internal static bool IsInteger(string str)
        {
            string pattern = "^[0-9]+$";
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                return match.Success;
            }
            return false;
        }


        internal static bool IsFloat(string str)
        {
            string pattern = "^[0-9]*[.][0-9]*$";
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                return match.Success;
            }
            return false;
        }
    }
}