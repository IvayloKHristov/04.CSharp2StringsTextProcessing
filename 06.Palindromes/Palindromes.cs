// Problem 6. Palindromes
// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe
// and prints them on the console on a single line, separated by comma and space. 
// Use spaces, commas, dots, question marks and exclamation marks as word delimiters. 
// Print only unique palindromes, sorted lexicographically.

using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Please, enter a text: ");
        char[] separators = new char[] { ' ', '\t', ',', '!',
            '?', ':', ';', '(', ')', '{', '}', '[', ']', '.' };
        string[] words = Console.ReadLine().Split(separators,
            StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            bool isPalindrome = true;
            for (int j = 0; j < words[i].Length / 2; j++)
            {
                if (words[i][j] != words[i][words[i].Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                palindromes.Add(words[i]);
            }
        }
        palindromes.Sort();
        Console.WriteLine("\nOutput:\n" + string.Join(", ", palindromes));
    }
}
