// Напишите программу, которая на вход принимает два числа и выдаёт: какое большее, а какое меньшее.
// a = 5; b = 7
// a = 2; b = 10
// a = -9; b = -3


int a, b;
Console.WriteLine("Введите первое число ");

a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

b = Convert.ToInt32(Console.ReadLine());

if (a < b)
    { 
    Console.WriteLine($"Большее число равно  {a} Меньшее число равно {b}");
    }
else
    {
        Console.WriteLine($"Большее число равно  {b} Меньшее число равно {a}");
    }

   