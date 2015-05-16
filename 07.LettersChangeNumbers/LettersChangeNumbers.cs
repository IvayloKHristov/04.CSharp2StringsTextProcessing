using System;

class LettersChangeNumbers
{
    static void Main()
    {
        char[] separators = new char[] { ' ', '\t' };
        string[] enter = Console.ReadLine().Split(separators,
            StringSplitOptions.RemoveEmptyEntries);
        decimal sum = 0;
        foreach (var item in enter)
        {
            decimal number = decimal.Parse(item.Substring(1, item.Length - 2));
            if ((item[0] > 64) && (item[0] < 91)) number /= (item[0] - 64);
            if ((item[0] > 96) && (item[0] < 123)) number *= (item[0] - 96);
            if ((item[item.Length - 1] > 64) && (item[item.Length - 1] < 91))
                number -= (item[item.Length - 1] - 64);
            if ((item[item.Length - 1] > 96) && (item[item.Length - 1] < 123))
                number += (item[item.Length - 1] - 96);
            sum += number;
        }
        Console.WriteLine("{0:F2}", sum);
    }
}
