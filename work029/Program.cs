// Написать программу вычисления произведения чисел от 1 до N
// Зная функцию лонг могу посчитать только до N = 20
// Цифры больше ещё не изучил

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите Число: ");
long N = Convert.ToInt64(Console.ReadLine());


long CompositionNumbers(long i)                                                                     // Метод вычисления произведения чисел в массиве чисел от 1 до N
{
    long composition = 1;
    for (long num = 1; num <= i; num++)
    {
        composition = composition * num;
    }
    return composition;
}

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {CompositionNumbers(N)}");           // Вывод и вызов метода
System.Console.WriteLine();