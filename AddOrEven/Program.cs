
Console.WriteLine("enter number:");
int userNum = Convert.ToInt32(Console.ReadLine());

// kas arv on paaris voi paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0) //!= - ei ole
{
    Console.WriteLine("number is odd");
}
else
{
    Console.WriteLine("number is even");
}
