

// 14. Найти третью цифру числа или сообщить, что её нет
long number;
System.Console.WriteLine("Введите число");                                                      // Ввод                               
number = Convert.ToInt32(Console.ReadLine());                                           
System.Console.WriteLine();                                                                     // Пустая строка


long digitCount = (long)Math.Log10(number) + 1;                                                   // Математическая функция определения длины числа(без неё не получается)

if (digitCount <= 2)                                                                            // условие
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    if (digitCount > 3)                                                                          // условие
    {
        number = number / Convert.ToInt32(Math.Pow(10, digitCount - 3));                         // Математическая функция степени
    }
    number = number % 10;                                                                        // Находим последнюю цифру числа
    System.Console.WriteLine($"Третья цифра введенного числа: {number}");

}