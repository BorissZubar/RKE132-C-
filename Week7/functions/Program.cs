Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello() //function / method
{
    Console.WriteLine("Hello, nerd!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, nerd.");
}
