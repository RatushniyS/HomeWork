// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите длину одномерного массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int n)
{
    int[] array = new int[n];
    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 100);
        System.Console.Write($"{array[i]}  ");
    }
    return array;
}

int[] SumOfEvenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];
    }
    System.Console.WriteLine($"Сумма чисел стоящих на нечетной позиции = {sum}");
    return array;
}

int[] array = NewArray(n);
System.Console.WriteLine();
int[] sum = SumOfEvenPosition(array);