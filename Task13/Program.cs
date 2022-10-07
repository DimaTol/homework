//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
if (number < 100)

    Console.WriteLine("Третьей цифры нет");

else while (number > 1000)

    number = number / 10;
    
if ((number < 1000) && (number > 99)) 
Console.WriteLine($"Третья цифра числа {num}: {number % 10}");


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
