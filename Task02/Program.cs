Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число {a} , меньшее число {b}");
}
else if (b > a)
{
    Console.WriteLine($"Большее число {b} , меньшее число {a}");
}



