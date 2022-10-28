// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 100);                                                             // присваеваем к number случайное целое число от 10 до 99
System.Console.WriteLine($"Число {number}");                                                        // вывод
System.Console.WriteLine();                                                                         // пустая строка

int FirstDigit = number / 10;                                                                       // поделив на 10 получим первую цифру (целое)
int SecondDigit = number % 10;                                                                      // остаток от деления

if (FirstDigit > SecondDigit)                                                                       // Если

    System.Console.WriteLine($"В числе {number} наибольшей цифврой является {FirstDigit}");         // Вывод

else
{
    System.Console.WriteLine($"В числе {number} наибольшей цифврой является {SecondDigit}");        // Вывод
}
