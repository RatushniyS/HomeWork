// Найти произведение двух матриц


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
            array[i, j] = new Random().Next(1, 10);
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


void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];                         // Всё просто)
            }
        }
    }
}




int i = InputArray("количество строк");
int j = InputArray("количество столбцов");
System.Console.WriteLine();
int[,] matrix = new int[i, j];
int[,] matrix2 = new int[i, j];
int[,] matrix3 = new int[i, j];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);

MatrixMultiplication(matrix, matrix2, matrix3);
System.Console.WriteLine("Результатом произведения первой и второй матрицы матрицы: ");
System.Console.WriteLine();
PrintArray(matrix3);
System.Console.WriteLine();



