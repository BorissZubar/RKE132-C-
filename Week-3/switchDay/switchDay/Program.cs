int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay) // vaartus, mida kontrollime
{
    case 0: // case 0: == if(weekDay == 0)
        Console.WriteLine("It is Sunday!");
        break;
    case 1:
        Console.WriteLine("It is Monday!");
        break;
    case 2:
        Console.WriteLine("It is Tuesday!");
        break;
    case 3:
        Console.WriteLine("It is Wednesday!");
        break;
    case 4:
        Console.WriteLine("It is Thursday!");
        break;
    case 5:
        Console.WriteLine("It is Friday!");
        break;
    case 6:
        Console.WriteLine("It is Saturday!");
        break;
    default:
        Console.WriteLine("Sorry, but your calender is broken. Sad, very sad...");
        break;
}

Console.WriteLine("Have a nice day!");