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


int[,] MatrixMultiplication(int[,] matrix, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (matrix.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


int i = InputArray("количество строк первой матрицы");      // matrix
int j = InputArray("количество столбцов первой матрицы");   // matrix
int m = InputArray("количество строк второй матрицы");      // matrix2
int n = InputArray("количество столбцов второй матрицы");   // matrix2
if (j != m) System.Console.WriteLine("Число столбцов первой должно соответствовать числу строк второй. Введите корректные данные");
else
{
    System.Console.WriteLine();
    int[,] matrix = new int[i, j];
    int[,] matrix2 = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    System.Console.WriteLine();
    FillArray(matrix2);
    PrintArray(matrix2);
    System.Console.WriteLine();
    System.Console.WriteLine("Результатом произведения первой и второй матрицы матрицы: ");
    MatrixMultiplication(matrix, matrix2);
    System.Console.WriteLine();
    PrintArray(MatrixMultiplication(matrix, matrix2));
    System.Console.WriteLine();


}
