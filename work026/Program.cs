﻿// Возведите число А в натуральную степень B используя цикл

System.Console.WriteLine("Введите Число которое нужно возвести в степень");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Степень");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; i < numberB - 1; i++)
{
    if (result == 0)
        result = numberA * numberA;
    else
        result = result * numberA;
}

System.Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
