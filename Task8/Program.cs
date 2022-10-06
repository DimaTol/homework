//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число: "); 
int numberN = Convert.ToInt32(Console.ReadLine()); 
int startnumber = 0; 
 
while (startnumber <= numberN) 
{ 
    // if (startnumber % 2 == 0) четность числа
    startnumber +=2; 
    Console.WriteLine($"Число:{startnumber}"); 
}

// else  
// { 
// startnumber++;
// }
// }




