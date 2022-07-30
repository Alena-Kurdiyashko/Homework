// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

double[,] arr = new double[2, 2];
double[] result = new double[2];

void FilIndex()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] arr)
{
    result[0] = (arr[1, 1] - arr[0, 1]) / (arr[0, 0] - arr[1, 0]);
    result[1] = result[0] * arr[0, 0] + arr[0, 1];
    return result;
}

void CheckCross(double[,] arr)
{
    if (arr[0, 0] == arr[1, 0] && arr[0, 1] == arr[1, 1])
    {
        Console.Write("Прямые совпадают");
    }
    else if (arr[0, 0] == arr[1, 0] && arr[0, 1] != arr[1, 1])
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        Decision(arr);
        Console.Write($"Точка пересечения прямых: ({result[0]}, {result[1]})");
    }
}

FilIndex();
CheckCross(arr);