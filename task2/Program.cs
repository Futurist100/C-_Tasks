// Напишите программу, которая на вход принимае число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int number;

Console.WriteLine("Введите число ");

number = Convert.ToInt32(Console.ReadLine());

int lastNumber = (number * 10)/2 % 10;

if (lastNumber == 5)
  
  { 
    Console.WriteLine("Число нечётное "); 
  }
  
else 
  { 
    Console.WriteLine("Число чётное ");
  }

