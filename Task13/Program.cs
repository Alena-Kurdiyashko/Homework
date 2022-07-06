// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
string newDigit  = Convert.ToString(digit);
if (newDigit.Length > 2){
  Console.WriteLine("Третья цифра  " + newDigit[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}