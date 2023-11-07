using System;

class anydigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (IsDigitsOnly(input))
        {
            int number = int.Parse(input);
            int sum = CalculateSumOfDigits(number);
            Console.WriteLine($"Sum of digits: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
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

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
