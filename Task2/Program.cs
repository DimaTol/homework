//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3

Console.WriteLine("Введите первое число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberB > max)
 {   
    max = numberB;
    min = numberA;
    
 }
else
{
    max = numberA;
    min = numberB;
}

Console.WriteLine ($"Максимальное число {max}");
Console.WriteLine ($"Минимальное число {min}");
