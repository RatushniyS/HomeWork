// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


int InputArray(string variable)
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
            array[i, j] = new Random().Next(0, 20);
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

double InputNumbers()
{
    Console.WriteLine("Введите число, которое нужно найти: ");
    double n = Convert.ToInt64(Console.ReadLine());
    return n;
}

void NumberSearch(double[,] array)
{
    double n = InputNumbers();
    bool x = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == n)
            {
                x = true;
                System.Console.WriteLine($"Число {n} находится на позиции {i},{j} ");
            }
        }
    }
    if (x == false)
    {
        System.Console.WriteLine($"Числа {n} в массиве НЕТ");
    }
}

int i = InputArray("количество строк");
int j = InputArray("количество столбцов");
System.Console.WriteLine();
double[,] matrix = new double[i, j];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
NumberSearch(matrix);
