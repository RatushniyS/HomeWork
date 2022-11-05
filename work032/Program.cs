// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
System.Console.WriteLine();

int[] CreateArray(int n)                                  // Метод создания массива из случайных чисел от 1 до 1000 той длинны которую ма зададим

{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 2);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int n = 8;

int[] array = CreateArray(n);                             // Вызов метода