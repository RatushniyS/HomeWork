// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
System.Console.WriteLine();

int[] Input()
{
    Console.Write("Введите числа через пробел: ");
    return Console.ReadLine().Split(" ").Select(int.Parse).ToArray();           //Спасибо, Евгений))) 
}
int checkOverZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > 0)
            count++;
    }

    return count;

}


int[] array = Input();
int count = checkOverZero(array);
Console.WriteLine($"Массив чисел {string.Join(", ", array)}");
System.Console.WriteLine($"Значений выше нуля -> {count}");




