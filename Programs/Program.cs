using System;
using System.Collections.Generic;

public class RomanToIntegerConverter
{
    private static readonly Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanValues[s[i]] < romanValues[s[i + 1]])
            {
                result -= romanValues[s[i]];
            }
            else
            {
                result += romanValues[s[i]];
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        string romanNumeral = "III";
        RomanToIntegerConverter converter = new RomanToIntegerConverter();
        int result = converter.RomanToInt(romanNumeral);
        Console.WriteLine($"Input: {romanNumeral}");
        Console.WriteLine($"Output: {result}");
    }
}
