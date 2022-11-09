// В прямоугольной матрице найти строку с наименьшей суммой элементов.




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
            array[i, j] = new Random().Next(0, 10);
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

void TheSumInARow(int[,] array)
{
    int minRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];                                  // Задаем строку с индексом 0 как минимальную
        
        
    }
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i, j];                              // Считаем сумму строки
        {
            if (sumRow < minRow)                                // Сравниваем с минимальной
            {
                minRow = sumRow;
                minSumRow = i;
                
            }
            else { sumRow = 0; }                                // Обнуляем сумму строки
        }
    }
    Console.Write($"Наименьшая сумма чисел в {minSumRow + 1} строке");

}

int i = InputArray("количество строк");
int j = InputArray("количество столбцов");
System.Console.WriteLine();
int[,] matrix = new int[i, j];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
TheSumInARow(matrix);



