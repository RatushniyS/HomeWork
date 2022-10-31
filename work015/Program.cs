// Дано число. Проверить кратно ли оно 7 и 23

int number1 = new Random().Next(1, 10000);                                                       // Задаем рандомные значения

System.Console.WriteLine($"Заданное число {number1}");                                           // Показывает какие значения сгенерировались

System.Console.WriteLine("Проверяем деление на 7 и 23");                                         // Пустая строка

if (number1 % 7 == 0 | number1 % 23 == 0)                                                        // Если number1 делится без остатка на number2
{
    System.Console.WriteLine($"Условие выполняется");                                            // Вывод
}
else
{
    System.Console.WriteLine($"Условие не выполняется");                                         // Вывод
}