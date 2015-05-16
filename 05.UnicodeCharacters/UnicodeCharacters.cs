// Problem 5. Unicode Characters
// Write a program that converts a string to a sequence of C# Unicode character literals. 

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Please, enter a string:");
        char[] text = Console.ReadLine().ToCharArray();
        string[] unicode = new string[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            unicode[i] = ((int)text[i]).ToString("X4").ToLower();
        }
        Console.WriteLine("\nOutput:\n\\u" + string.Join("\\u", unicode));
    }
}

