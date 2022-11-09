//  Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива


Console.Clear();
System.Console.WriteLine();


int InputArray(string variable)
{
    Console.WriteLine($"Введите {variable}");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}


void BubblerSortDescendingOrder(int[,] array)                           // Сортируем пузырьком по методу стаканчиков
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}




int i = InputArray("количество строк");
int j = InputArray("количество столбцов");
System.Console.WriteLine();
int[,] matrix = new int[i, j];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
BubblerSortDescendingOrder(matrix);
PrintArray(matrix);

System.Console.WriteLine();
