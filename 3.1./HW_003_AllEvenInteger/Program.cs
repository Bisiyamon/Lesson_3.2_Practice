Console.Write("Input amout varriables: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

void FillArray(int[] numbers)
{
    int index = 0;

    while (index < n)
    {
        numbers[index] = index + 1;
        index++;
    }
}

void PrintArray(int[] PrintNumber)
{
    int position = 0;
    while(position < n)
    {
        Console.Write(" / ");
        Console.Write(PrintNumber[position]);
        position++;
    }
}

void EvenInteger(int[] number) 
{
    int index = 0;
    int even_number = 0;

    while(index < n)
    {
        if(number[index] % 2 == 0)
        {
            Console.Write(" / ");
            Console.Write(number[index]);
        }
        index++;
    }
} 

int[] array = new int[n];

FillArray(array);

Console.Write("Your Array: ");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

Console.Write("All even numbers: ");
EvenInteger(array);
Console.WriteLine();
Console.WriteLine();