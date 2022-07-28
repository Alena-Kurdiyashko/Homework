// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] CreateArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++ )
    { 
        arr[i] = rnd.NextDouble() * 10;

    }
    return arr;
}

void PrintArray (double[] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",  ");
        else Console.Write(arr[i] + "]");
    }
}

double MaxMinElem (double[] arr)
{
    double maxNumb = arr[0];
    double minNumb = arr[0];
    for(int i = 0; i< arr.Length; i++)
    {
        if (maxNumb < arr[i])
        {
            maxNumb = arr[i];
        }
        if (minNumb> arr[i])
        {
            minNumb = arr[i];
        }

    }
    return maxNumb - minNumb;
}

double [] array = CreateArray(6, 10, 20);
PrintArray(array);
double result = MaxMinElem(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементам = {result}");
