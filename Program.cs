Console.Clear ();
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int N;
int n = 0;
int ost= (n % 2);
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine ()!, out N);

while (n <= N)
{
    if (ost == 0) 
    {
Console.Write($"{n}, ");
    n = n + 2;
    } 
    else
    {
    n = n +1;
    }
}
