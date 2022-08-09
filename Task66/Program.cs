// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()!);

int GetSumFromMtoN(int m, int n)
{
    if (n > m)
        return n + GetSumFromMtoN(m, n - 1);
    return m;
}

int sum = GetSumFromMtoN(m, n);
Console.WriteLine($"Сумма чисел от m до n: " + sum);