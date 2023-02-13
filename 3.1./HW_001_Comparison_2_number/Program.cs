Console.Write("Input amout varriables: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] numbers)
{
    int index = 0;
    while (index < n)
    {
        numbers[index] = Convert.ToInt32(Console.ReadLine());
        //index = index + 1;
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
        //position = position + 1;
        position++;
    }
}

int Comparison(int[] number) 
{
    int index = 0;
    int max = 0;

    while(index < n)
    {
        if(number[index] > max)
        {
            max = number[index];
        }
        index++;
    }
    return max;
} 

int[] array = new int[n];

Console.WriteLine("Enter numbers");
FillArray(array);
Console.WriteLine();

Console.Write("Your Array: ");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int maxnumber = Comparison(array);
Console.Write("Max number in your array: ");
Console.WriteLine(maxnumber);
Console.WriteLine();