Console.Write("Enter a day of week: ");
string DayOfWeek = Console.ReadLine();
 
//Проверка являются ли введенные данные число или символами(буквы) 
if(int.TryParse(DayOfWeek,out int number))
{
    //Условия вывода информации если введено число
   switch(number)
    {
    case 1:
        Console.WriteLine("This number of day of the week relevants to Monday. It's working day.");
        break;
    case 2:
        Console.WriteLine("This number of day of the week relevants to Tuesday. It's working day.");
        break;
    case 3:
        Console.WriteLine("This number of day of the week relevants to Wednesday. It's working day.");
        break;
    case 4:
        Console.WriteLine("This number of day of the week relevants to Thursday. It's working day.");
        break;
    case 5:
        Console.WriteLine("This number of day of the week relevants to Friday. It's working day. But tommorow you will rest!");
        break;
    case 6:
        Console.WriteLine("This number of day of the week relevants to Saturday. It's weekend!");
        break;
    case 7:
        Console.WriteLine("This number of day of the week relevants to Sunday. It's weekend!");
        break;
    default:
        Console.WriteLine("There is no such a weekday.");
        break;
    }
}
else
{
    //Условия вывода информации если введено название дня
    switch(DayOfWeek)
    {
    case "Monday":
        Console.WriteLine("Number of this name of the day of the week is 1. It's working day.");
        break;
    case "Tuesday":
        Console.WriteLine("Number of this name of the day of the week is 2. It's working day.");
        break;
    case "Wednesday":
        Console.WriteLine("Number of this name of the day of the week is 3. It's working day.");
        break;
    case "Thursday":
        Console.WriteLine("Number of this name of the day of the week is 4. It's working day.");
        break;
    case "Friday":
        Console.WriteLine("Number of this name of the day of the week is 5. It's working day. But tommorow you will rest!");
        break;
    case "Saturday":
        Console.WriteLine("Number of this name of the day of the week is 6. It's weekend!");
        break;
    case "Sunday":
        Console.WriteLine("Number of this name of the day of the week is 7. It's weekend!");
        break;
    default:
        Console.WriteLine("There is no such a weekday. Maybe you wrote wrong.");
        break;
    }
}
