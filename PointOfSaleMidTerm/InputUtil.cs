using System;
using System.Collections.Generic;

namespace PointOfSaleMidTerm
{
    public class InputUtil
    {
        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static bool GetYesNo(string prompt)
        {
            string[] trueValues = { "y", "yes" };
            string[] falseValues = { "n", "no" };
            return GetInputBool(prompt, trueValues, falseValues);
        }
        public static bool GetInputBool(string prompt, string[] trueValues, string[] falseValues)
        {
            List<string> acceptableTrueValues = new List<string>(trueValues);
            acceptableTrueValues.Add("t");
            acceptableTrueValues.Add("true");
            List<string> acceptableFalseValues = new List<string>(falseValues);
            acceptableFalseValues.Add("f");
            acceptableFalseValues.Add("false");
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().Trim().ToLower();
                if (acceptableTrueValues.Exists(input.Equals))
                {
                    return true;
                }
                else if (acceptableFalseValues.Exists(input.Equals))
                {
                    return false;
                }
                Console.WriteLine("t=true/f=false expected!");
            }
        }
        public static DateTime GetInputDate(string message)
        {
            while (true)
            {
                try
                {
                    string input = ReadString(message);
                    if (input.Length > 0)
                    {
                        return DateTime.Parse(input);
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
        public static string GetInputString(string message)
        {
            while (true)
            {
                try
                {
                    string input = ReadString(message);
                    if (input.Length > 0)
                    {
                        return input;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
        public static double ReadDouble(string message, double minValue, double maxValue)
        {
            while (true)
            {
                try
                {
                    double number = -1;
                    string input = ReadString(message);
                    number = double.Parse(input);
                    if (number >= minValue && number <= maxValue)
                    {
                        return number;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static int ReadInteger(string message, int minValue, int maxValue)
        {
            while (true)
            {
                try
                {
                    int number = -1;
                    string input = ReadString(message);
                    number = int.Parse(input);
                    if (number >= minValue && number <= maxValue)
                    {
                        return number;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
