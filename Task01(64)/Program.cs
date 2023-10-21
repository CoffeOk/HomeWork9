/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void NatNum (int number)
{
    if (number == 0) return;
        Console.Write($"{number} ");
        if (number > 0)
            NatNum (number - 1);
        if (number < 0)
            NatNum (number + 1);
}

int num, n;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out num))
    Console.WriteLine("Введите целое число");
n = num;
Console.Write($"N = {n} -> ");
NatNum(num);