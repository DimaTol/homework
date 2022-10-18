
int number = Convert.ToInt32(Console.ReadLine());
int lenght = number.ToString().Length;
string str = number.ToString();
int i = 0;
int j = 0;

for (i = 0; i < lenght / 2; i++)
if (str[i] == str[lenght - 1 - i])
{
j++;
}
if (j == lenght / 2)
{
    Console.WriteLine("Введенное число палиндром");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}
