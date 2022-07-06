// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());

if (dayN == 6 || dayN == 7) 
{
    Console.WriteLine("Да, это выходной!");
}
else if (dayN < 1 || dayN > 7)
{
    Console.WriteLine("Такого дня недели нет :(");

}
else Console.WriteLine("Нет, этот день не выходной");