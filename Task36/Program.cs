// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++ )
    { 
        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int SumElement ( int[] arr)
{
     int sumElements = 0;
     for (int i = 0; i< arr.Length; i++)
           if (i % 2 != 0)
      {
        sumElements = sumElements + arr[i];
      }
      return sumElements;

}

int [] array = CreateArray(5, 10, 50);
PrintArray(array);
int sum = SumElement(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum} ");



   



// Console.Write($"Введи количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");