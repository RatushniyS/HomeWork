﻿// Даны 2 числа. Показать большее и меньшее число
System.Console.WriteLine("Number1");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("number2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    System.Console.WriteLine($"Число {number1} Большее,  Число {number2} Меньшее");
}
else
{
    System.Console.WriteLine($"Число {number1} Меньшее,  Число {number2} Большее");
}
