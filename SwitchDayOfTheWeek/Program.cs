int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay) //vaartus, mida kontrollitakse
{
    case 0: //case 0: == if(weekDay == 0)
        Console.WriteLine("Sunday");
        break;

    case 1: Console.WriteLine("Monday");
        break;
    case 2: Console.WriteLine("Tusday");
        break;
    case 3: Console.WriteLine("Wednesday");
        break;
    case 4: Console.WriteLine("Thurstday");
        break;
    case 5: Console.WriteLine("Friday");
        break;
    case 6: Console.WriteLine("Saturday");
        break;
    default: Console.WriteLine("Oops. Your calender must be broken");
        break;
}

Console.WriteLine("Hvae a nice day");
