// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

int number;
System.Console.Write("Введите число от 1 до 7:");                                           // Ввод
number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)                                                             // Условие
{
    if (number == 6 | number == 7) System.Console.WriteLine("Сегодня выходной");            // Условие если number = 6 ИЛИ number = 7, Вывод
    else System.Console.WriteLine("Сегодня рабочий день");                                  // Вывод
}
else System.Console.WriteLine("Не верное число");                                           // Вывод