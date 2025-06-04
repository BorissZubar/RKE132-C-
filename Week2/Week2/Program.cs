using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, select your gender (m/f):");

        char userGender = Char.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter your last name:");
        string userLastName = Console.ReadLine();

        if (userGender == 'm')
        {
            Console.WriteLine($"Welcome, Mr. {userLastName}!");
        }
        else if (userGender == 'f')
        {
            Console.WriteLine($"Welcome, Ms. {userLastName}!");
        }
        else
        {
            Console.WriteLine($"Welcome, {userLastName}!");
        }

        Console.WriteLine("The program will close in 10 seconds...");
        Thread.Sleep(10000);
    }
}

