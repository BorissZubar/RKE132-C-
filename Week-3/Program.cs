
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0)
{
    Console.WriteLine("It is Sunday!");
}
else if(weekDay == 1)
{
    Console.WriteLine("It is Monady!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It is Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It is Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It is Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It is Fiday!");
}
else if (weekDay == 6)
{
    Console.WriteLine("It is Saturday!");
}
Console.WriteLine("Have a nice day!!");
