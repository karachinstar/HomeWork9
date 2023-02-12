/*Задача 64:
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью
рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void Fuct(int num)
{
    if (num != 0)
    {
        if (num > 1)
        Console.Write($"{num}, ");
        else Console.Write($"{num}");
        Fuct(num - 1);
    }
    else
        Console.Write("");
}
Console.Write("Введите начальное число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {x} -> '");
Fuct(x);
Console.Write("'");