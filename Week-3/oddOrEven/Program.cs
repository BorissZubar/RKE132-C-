

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris v6i paaritu

int result = userNum % 2;

Console.WriteLine(result);

if(result != 0) // != ei ole v6rdne
{
    Console.WriteLine("User number is odd");
}
else
{
    Console.WriteLine("User number is even");
}

