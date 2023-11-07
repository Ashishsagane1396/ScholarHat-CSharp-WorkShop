using System;
using System.Linq;

class fivedigit
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        string input = Console.ReadLine();

        if (input.Length != 5 || !IsDigitsOnly(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid five-digit number.");
        }
        else
        {
            int sum = input.Select(digit => int.Parse(digit.ToString())).Sum();
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }

    static bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
