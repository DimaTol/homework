//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число: "); 
int numberN = Convert.ToInt32(Console.ReadLine()); 
int startnumber = 1; 
 
while (startnumber <= numberN) 
{ 
    if (startnumber % 2 == 0) 
{ 
    Console.WriteLine($"Четное число:{startnumber}"); 
    startnumber +=2; 
} 
else  
{ 
startnumber++; 
}
}




