Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int remains = number%10;
if(number > 99 & number <1000)
{
    Console.Write("The last digit in your number = ");
    Console.WriteLine(remains);
}
else
{
    Console.WriteLine("Read carefully, you need input three-digit number");
}