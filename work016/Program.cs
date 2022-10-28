// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
int number;
System.Console.Write("Введите число от 1 до 7:");
number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    if (number == 6 | number == 7) System.Console.WriteLine("Сегодня выходной");
    else System.Console.WriteLine("Сегодня рабочий день");
}
else System.Console.WriteLine("Не верное число");