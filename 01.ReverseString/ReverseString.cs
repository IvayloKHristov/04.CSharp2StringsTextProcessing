// Problem 1. Reverse String
// Write a program that reads a string from the console, reverses it and prints the result back at the console.

using System;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please, enter a string:");
        char[] input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        Console.WriteLine("\nOutput:");
        Console.WriteLine(input);
    }
}

