using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int age = RequestAge();

        ShowAccessMessage(age);

        Console.WriteLine("The application will exit in 10 seconds...");
        Thread.Sleep(10000);
    }

    static int RequestAge()
    {
        int result;
        while (true)
        {
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out result))
                break;

            Console.WriteLine("Invalid input. Only numbers are allowed.");
        }

        return result;
    }

    static void ShowAccessMessage(int age)
    {
        Console.WriteLine($"You entered: {age} years old.");

        if (age >= 13)
        {
            Console.WriteLine("Access granted: Welcome to Instagram.");
        }
        else
        {
            Console.WriteLine("Access denied: You must be at least 13 years old to use Instagram.");
        }
    }
}

