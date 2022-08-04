// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет



Console.WriteLine("Номер строки искомого элемента: ");
int posInRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Номер столбца искомого элемента: ");
int posInColumn = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

int FindElementInMatrix(int[,] mtrx, int posInRow, int posInColumn)
{
    int element = 0;

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i == posInRow - 1 && j == posInColumn - 1) element = mtrx[i, j];
        }
    }
    return element;
}

int[,] array = GetMatrix(4, 3, 0, 100);
PrintMatrix(array);
Console.WriteLine();

if (FindElementInMatrix(array, posInRow, posInColumn) > 0)
{
    Console.WriteLine("Значение выбранного элемента: " + FindElementInMatrix(array, posInRow, posInColumn));
}
else
{
    Console.WriteLine("Такого элемента в этом массиве нет!");
}
