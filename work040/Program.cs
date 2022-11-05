//  В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

double[] NewArray(int n)
{
    double[] array = new double [n];
   
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        System.Console.Write($"{array[i]}  ");
    }
    return array;
}

double MaxValue(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    System.Console.WriteLine($"Максимальное значение = {max}");
    return max;
}

double MinValue(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Минимальное значение = {min}");
    return min;
}

double Difference(double max, double min)
{
    double DifferenceValue = 0;
    DifferenceValue = max - min;
    System.Console.WriteLine($"Разница чисел = {max - min} ");
    return DifferenceValue;
}

double[] array = NewArray(n);

System.Console.WriteLine();

double max = MaxValue(array);

double min = MinValue(array);

double DifferenceValue = Difference(max, min);