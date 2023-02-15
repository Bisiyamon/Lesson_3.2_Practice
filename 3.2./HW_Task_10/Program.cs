Console.Write("Input your number: ");
string num = Console.ReadLine();

char[] symbols = num.ToCharArray();

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

for(int i=0; i<symbols.Length; i++)
{
    if (i == position)
    {
        Console.Write("Do you want to see this digit: {0}", symbols[i]);
    }
  
}
Console.WriteLine();