// Напишите программу, которая на вход принимает три числа и выддаёт максимальное из этих чисел.
// 2,3,7 ->7
// 44,5,78 ->
// 22,3,9 ->

int a,b,c;

Console.WriteLine("Введите первое число ");

a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число ");

c = Convert.ToInt32(Console.ReadLine());

int max = a;

if 
   (a > b && a > c) 

   {
    Console.WriteLine($"Большее число равно  {a}");

   }

else 
     
     { 
        if (b < c) 
     {
        Console.WriteLine($"Большее число равно  {c}");
     }
     
     else 
     {
        Console.WriteLine($"Большее число равно  {b}");
     }
     
     }
   
