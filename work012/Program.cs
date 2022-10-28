// 12. Удалить вторую цифру трёхзначного числа

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());                                                        // Ввод

System.Console.WriteLine();                                                                              // Пустая строка

int newNumber = 0;

if (999 > number && number > 99)                                                                         // Если number меньше 1000 и больше 99
    
    {
    newNumber = number / 100 * 10 + number % 10;                                                        // Убираем вторую цифру
    System.Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {newNumber}");  // Вывод
    }
else                                                                                                     // Иначе
{
    System.Console.WriteLine("Начните заново и Введите корректное число");                               // Вывод
}

 