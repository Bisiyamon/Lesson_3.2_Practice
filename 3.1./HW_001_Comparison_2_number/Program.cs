Console.Write("Input amount varriables: "); //Вводим количество цифр для ввода
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

int ComparisonMax(int[] number) 
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

int ComparisonMin(int[] number) 
{
    int index = 0;
    int min = number[index];

    while(index < n)
    {
        if(number[index] < min)
        {
            min = number[index];
        }
        index++;
    }
    return min;
} 

int[] array = new int[n];

Console.WriteLine("Enter numbers");
FillArray(array);
Console.WriteLine();

Console.Write("Your Array: ");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int minnumber = ComparisonMin(array);
Console.Write("Minimal number in your array: ");
Console.WriteLine(minnumber);
Console.WriteLine();

int maxnumber = ComparisonMax(array);
Console.Write("Maximum number in your array: ");
Console.WriteLine(maxnumber);
Console.WriteLine();