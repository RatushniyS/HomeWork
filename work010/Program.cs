// 10. Показать вторую цифру трёхзначного числа

System.Console.WriteLine("Введите трехзначное число");                                          // Ввод
int number = Convert.ToInt32(Console.ReadLine());                                               // присваиваем

System.Console.WriteLine();                                                                     // Пустая строка

if (1000 > number && number > 99)                                                               // Если number меньше 1000 и больше 99
    System.Console.WriteLine($"Последняя цифра чила {number} является: {number / 10 % 10} ");   // Вывод (остаток от деления на 10 после деления на 10, целочисленное)
else                                                                                            // Иначе
{
    System.Console.WriteLine("Начните заново и Введите корректное число");                      // Вывод
}