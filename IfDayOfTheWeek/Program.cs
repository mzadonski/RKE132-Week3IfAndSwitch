

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Sunday!");

}
else if (weekDay == 1)
{
    Console.WriteLine("Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Tusday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Thirsday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("Friday!");
}
else
{
    Console.WriteLine("Saturday!");
}
Console.WriteLine("Good day to you, sir!");