// По двум заданным числам проверять является ли одно квадратом другого

System.Console.WriteLine("Введите первое число от 1 до 10");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число от 1 до 100");
int number2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

if (number1 < 11 && number2 < 101)
{
    if (number2 == number1 * number1)
    {
        System.Console.WriteLine($"Число {number2} является квадратом числа {number1}");                                          // Convert.ToInt32(Math.Pow(number1, digitCount 2)
    }
    else
    {
        System.Console.WriteLine($"Число {number2} НЕ является квадратом числа {number1}");
    }

}

else
{
    System.Console.WriteLine("Введите верные числа");
}
