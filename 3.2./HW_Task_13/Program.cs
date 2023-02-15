Console.Write("Input your number: ");
string num = Console.ReadLine();

char[] symbols = num.ToCharArray();

Console.Write("Array of digits: ");
foreach (char ch in symbols)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");
Console.WriteLine();

Console.Write("Please specify the number of position of the digit to be showed: ");
int input_position = Convert.ToInt32(Console.ReadLine());
int position = input_position-1;


if (position < symbols.Length)
{
    Console.WriteLine("You choose number is {0}", symbols[position]);
}
else
{
    Console.WriteLine("Amount of symbols is | {0} | you want to delete position | {1} |. It's impossible. You need to specify another number of position!", num.Length, input_position);
}
Console.WriteLine();