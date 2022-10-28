

// 14. Найти третью цифру числа или сообщить, что её нет
int number;
System.Console.WriteLine("Введите число");                                                 
number = Convert.ToInt32(Console.ReadLine());                                           
System.Console.WriteLine();


int digitCount = (int)Math.Log10(number) + 1;

if (number <= 2)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    if (digitCount > 3)
    {
        number = number / Convert.ToInt32(Math.Pow(10, digitCount - 3));
    }
    number = number % 10;
    System.Console.WriteLine($"Третья цифра введенного числа: {number}");

}

