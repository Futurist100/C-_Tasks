// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2,4
// 8 -> 2,4,6,8

int a;

Console.WriteLine("Введите число ");

a = Convert.ToInt32(Console.ReadLine());

int b = Math.Abs(a);

int count = 2;

if (b == 1)
  
   {
    Console.WriteLine("В заданном диапазоне чётных чисел нет ");
   }

else 
   { 
    while (count <= b)
    {
        if (a == b)
        {
            Console.WriteLine(count);
            count = count +2;
        }
        else
        {
            Console.WriteLine($"-{count}");
            count = count +2;
        }

    }
   }