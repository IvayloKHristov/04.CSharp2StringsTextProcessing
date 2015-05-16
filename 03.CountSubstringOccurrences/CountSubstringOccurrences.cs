// Problem 3. Count Substring Occurrences
// Write a program to find how many times a given string appears in a given text as substring. 
// The text is given at the first input line. The search string is given at the second input line. 
// The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountSubstringOccurrences
{
    static void Main()
    {
        Console.WriteLine("Please, enter some text:");
        string input = Console.ReadLine().ToLower();
        Console.WriteLine("Please, enter a substring to search for:");
        string sub = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < input.Length - (sub.Length - 1); i++)
        {
            string subInput = input.Substring(i, sub.Length);
            if (subInput == sub) count++;
        }
        Console.WriteLine("\nOutput:\n" + count);
    }
}

