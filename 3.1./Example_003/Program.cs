Console.Write("Enter a day of week: ");
string DayOfWeek = Console.ReadLine();

if(int.TryParse(DayOfWeek,out int number))
{
    if(number == 1)
    {
        Console.WriteLine("This number of day of the week relevants to Monday");
    }

    if(number == 2)
    {
        Console.WriteLine("This number of day of the week relevants to Tuesday");
    }

    if(number == 3)
    {
        Console.WriteLine("This number of day of the week relevants to Wednesday");
    }

    if(number == 4)
    {
        Console.WriteLine("This number of day of the week relevants to Thursday");
    }

    if(number == 5)
    {
        Console.WriteLine("This number of day of the week relevants to Friday");
    }

    if(number == 6)
    {
        Console.WriteLine("This number of day of the week relevants to Saturday");
    }

    if(number == 7)
    {
        Console.WriteLine("This number of day of the week relevants to Sunday");
    }
}

else
{
    if (DayOfWeek == "Monday")
    {
        Console.WriteLine("Number of this name of the day of the week is 1");
    }

    if (DayOfWeek == "Tuesday")
    {
        Console.WriteLine("Number of this name of the day of the week is 2");
    }

    if (DayOfWeek == "Wednesday")
    {
        Console.WriteLine("Number of this name of the day of the week is 3");
    }

    if (DayOfWeek == "Thursday")
    {
        Console.WriteLine("Number of this name of the day of the week is 4");
    }

    if (DayOfWeek == "Friday")
    {
        Console.WriteLine("Number of this name of the day of the week is 5");
    }

     if (DayOfWeek == "Saturday")
    {
        Console.WriteLine("Number of this name of the day of the week is 6");
    }

    if (DayOfWeek == "Sunday")
    {
        Console.WriteLine("Number of this name of the day of the week is 7");
    }
}