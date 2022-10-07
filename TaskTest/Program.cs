// Задача 13: Напишите программу,
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberThird = number;

if (number<=99)

   Console.WriteLine($"Такой цифры нет");

else
while (number>999)

       number = number - 1; 
  
        Console.WriteLine ($"Третья цифра числа {numberThird% 10}");

number++;

