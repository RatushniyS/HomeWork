// Написать программу вычисления произведения чисел от 1 до N
// Зная функцию лонг могу посчитать только до N = 20
// Цифры больше ещё не изучил

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите Число: ");
long N = Convert.ToInt64(Console.ReadLine());


long CompositionNumbers(long i)
{
    long composition = 1;
    for (long num = 1; num <= i; num++)
    {
        composition = composition * num;
    }
    return composition;
}

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {CompositionNumbers(N)}");
System.Console.WriteLine();