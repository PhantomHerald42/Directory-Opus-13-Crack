using System;
using System.Collections.Generic;
using System.Linq;
public static class StringUtilities
{
    public static int CountVowels(string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }
        return count;
    }
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static string ToTitleCase(string input)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }
    public static Dictionary<char, int> CharacterFrequency(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }
        return frequency;
    }
    public static bool IsPalindrome(string input)
    {
        string reversed = ReverseString(input);
        return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
    }
    public static string RemoveWhitespace(string input)
    {
        return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
    }
    public static string[] SplitByDelimiter(string input, char delimiter)
    {
        return input.Split(delimiter);
    }
    public static string JoinStrings(IEnumerable<string> strings, string separator)
    {
        return string.Join(separator, strings);
    }
}
