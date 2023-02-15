//Вводим число
Console.Write("Input your number: ");
string num = Console.ReadLine();

//Переводим число в массив из цифр
char[] symbols = num.ToCharArray();

//Вывод числа в ввиде отдельных цифр массива
foreach (char ch in symbols)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");

//Вводим номер позиции числа, которое необходимо показать
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