//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int nums = num;
if (num < 100)

    Console.WriteLine("Третьей цифры нет");

else while (num > 1000)

    num = num / 10;
    
if ((num < 1000) && (num > 99)) 
Console.WriteLine($"Третья цифра числа {nums}: {num % 10}");


// Решение задачи через массив
// Console.Write("Введи число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string numberText = Convert.ToString(number);

// if (numberText.Length > 2)
// {
//   Console.WriteLine("третья цифра: " + numberText[2]);
// }
// else
// {
//   Console.WriteLine("Нет третьей цифры");
// }
