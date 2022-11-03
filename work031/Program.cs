// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.



Console.Clear();
System.Console.WriteLine();

int[] CreateRandomArray(int n)                                  // Метод создания массива из случайных чисел от 1 до 1000 той длинны которую ма зададим

{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

System.Console.WriteLine("Введите Число");
int n = Convert.ToInt32(Console.ReadLine());                    // Длинна массива

int[] array = CreateRandomArray(n);                             // Вызов метода