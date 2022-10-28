// Даны 2 числа. Показать большее и меньшее число
System.Console.WriteLine("Number1");    // Вводим первое значение
int number1 = Convert.ToInt32(Console.ReadLine());  // целое число Number1 считавает введенную выше строку
System.Console.WriteLine("number2");    // Вводим второе значение
int number2 = Convert.ToInt32(Console.ReadLine());      // целое число Number2 считывает введенную выше строку
if (number1>number2)        // условие если 1 больше 2
{
    System.Console.WriteLine($"Число {number1} Большее,  Число {number2} Меньшее");     // Выводим Число 1 большее Число 2 меньшее
}
else
{
    System.Console.WriteLine($"Число {number1} Меньшее,  Число {number2} Большее");     // Выводим Число 1 меньшее Число 2 большее
}
