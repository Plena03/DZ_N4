//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.    5 -> 2, 4      8 -> 2, 4, 6, 8

Console.WriteLine ("Программа показывает все четные числа от 1 до N");

Console.WriteLine ("Введите число N: ");

string? numberString = Console.ReadLine (); 

int number =  int.Parse (numberString!);

int n = 2;

if ((number / 2) *2 != number)
        {
        number = number-1; 
        }

while (n <= number)
    {
        Console.WriteLine(n);
        n += 2;
    }
