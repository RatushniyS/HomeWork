// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();
Console.WriteLine();

int[] NewArray(int n)
{
    int[] array = new int[n];
    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

void even(int[] array)
{
    int countEven = 0;
    int countUnEven = 0;
    System.Console.WriteLine();
    System.Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;
        else countUnEven++;
    }
    System.Console.WriteLine($"Количество четных чисел {countEven}, Количесво НЕ четных чисел {countUnEven}");

}


int n = 50;

int[] array = NewArray(n);
even(NewArray(n));
