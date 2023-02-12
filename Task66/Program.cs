/*Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Fuct(int num, int num1)
{
    if (num < num1)
    {
        return num + Fuct(num + 1, num1);
        //Console.Write($"{num1}, ");
    }
    else
        return num;
}
Console.WriteLine("Введите начальное число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {x}; N = {y} -> ");
Console.Write(Fuct(x, y));