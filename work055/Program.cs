// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов


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
            array[i, j] = new Random().Next(1, 20);
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

double[] AvgMatrix(int[,] array)
{
    
    double[] array1 = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];
        }
        array1[i] = result / array.GetLength(0);
    }
    return array1;
}

void PrintArrayList(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i].ToString("F" + 3) + "\t");
    }

}


int i = InputArray("количество строк");
int j = InputArray("количество столбцов");
System.Console.WriteLine();
int[,] matrix = new int[i, j];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();

double[] array1 = AvgMatrix(matrix);
PrintArrayList(array1);

