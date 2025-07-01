// app for finding factorial of an inputted number

using System;

class factorial
{
    public static void Main()
    {
        Console.Write("Enter number: "); // prompt user to enter number
        int num = int.Parse(Console.ReadLine()); // save an int variable
        Console.Write($"Number Factorial is: {Factorial(num)}"); // display num back to user
    }

    // factorial method
    static int Factorial(int num)
    {
        // base case
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}
