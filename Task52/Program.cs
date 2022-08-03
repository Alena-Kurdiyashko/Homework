// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear();
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 20);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} |");

        }
        Console.WriteLine();
    }
}

void Decision(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arithmeticMean += arr[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / m, 1);
        Console.WriteLine($"Среднее арифметическое столбца № {i + 1} {arithmeticMean}");
    }
}

int[,] array = CreateMatrixRndInt(m, n);

PrintMatrix(array);
Decision(array);