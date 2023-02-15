Console.Write("Random number: ");
Random random_number = new Random();
int num = random_number.Next(100, 20000);
string a = num.ToString();
Console.WriteLine(num);

char[] symbols = a.ToCharArray();

foreach (char ch in symbols)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");

Console.WriteLine();
Console.Write("Please specify the number of position of the digit to be deleted: ");
int input_position = Convert.ToInt32(Console.ReadLine());
int position = input_position-1;

//Console.WriteLine("Input_Position: {0}", input_position);
//Console.WriteLine("Position: {0}", position);

Console.Write("New number: ");
for(int i=0; i<symbols.Length; i++)
{
    if (i == position)
    {
        continue;
    }
    Console.Write(symbols[i]);
}
Console.WriteLine();