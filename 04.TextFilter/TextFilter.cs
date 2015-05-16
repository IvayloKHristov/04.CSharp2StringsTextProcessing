// Problem 4. Text Filter
// Write a program that takes a text and a string of banned words.
// All words included in the ban list should be replaced with asterisks "*", equal to the word's length. 
// The entries in the ban list will be separated by a comma and space ", ".
// The ban list should be entered on the first input line and the text on the second input line. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        Console.WriteLine("Please, enter the banned words, separated by a comma and space:");
        string enter = Console.ReadLine();
        Console.WriteLine("Please, enter some text:");
        char[] separators = new char[] { ' ', ',' };
        string[] banned = enter.Split(separators,
            StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        for (int i = 0; i < banned.Length; i++)
        {
            text = text.Replace(banned[i],
                new string('*', banned[i].Length));
        }
        Console.WriteLine("\nOutput:\n" + text);
    }
}

