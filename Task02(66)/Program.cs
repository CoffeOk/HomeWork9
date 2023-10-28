/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNut(int x, int y)
{
    if (x < y)
    return SumNut(x, y-1) + y;
    else if (x > y)
    return SumNut(x - 1, y) + x;
    else
    return x;
}

int n, m;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out m))
    Console.WriteLine("Введите целое число");

Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.WriteLine("Введите целое число");

int sum = SumNut (m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");