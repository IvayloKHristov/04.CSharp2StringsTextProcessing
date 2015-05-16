// Problem 2. String Length
// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with *. 
// Print the resulting string on the console.

using System;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please, enter a string:");
        string input = Console.ReadLine();
        if (input.Length > 20) input = input.Substring(0, 20);
        Console.WriteLine("\nOutput:");
        Console.WriteLine(input.PadRight(20, '*'));
    }
}

