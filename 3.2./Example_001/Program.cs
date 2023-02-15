Console.Write("Random number: ");
Random random_number = new Random();
int num = random_number.Next(100, 10000);
string a = num.ToString();
Console.WriteLine(num);

Console.Write("Please specify the number of position of the digit to be deleted: ");
int input_position = Convert.ToInt32(Console.ReadLine());
int position = input_position-1;

if (position < a.Length)
{
    string number = a.Remove(position, 1);
    Console.WriteLine("New number is {0}", number);
}
else
{
    Console.WriteLine("Amount of symbols is | {0} | you want to delete position | {1} |. It's impossible. You need to specify another number of position!", a.Length, input_position);
}

