//Программа, которая на вход принимает одно число N на выходе получаем ряд от -N до N
Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int reverse = -a;
int count=reverse;

while(count<=a)
{
    Console.Write(count);
    Console.Write(" / ");
    count=count+1;
}
