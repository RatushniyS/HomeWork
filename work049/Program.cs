// Задайте двумерный массив размером i×j, заполненный случайными вещественными числами.

int Input(string variable)
{
    Console.WriteLine($"Введите {variable}");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble ();
        }
    }
}

void PrintArray(double[,] array)
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

int i = Input("количество строк");
int j = Input("количество столбцов");
double[,] matrix = new double[i, j];
FillArray(matrix);
PrintArray(matrix);
