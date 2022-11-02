// Написать программу, которая преобразует массив целых чисел в массив чисел, в котором находятся только четные числа

// System.Console.WriteLine("Введите длину массива");
// arrayA.Length = Convert.ToInt32(Console.ReadLine()); 

int[] arrayA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] arrayB = new int [arrayA.Lenght];
int x = 0;
int y = 0;

while (x < arrayA.Length)
{
    if (arrayA[x] % 2 == 0)
    {
        arrayB[y] = arrayA[x];
        y++;
            }
    x++;
}

System.Console.WriteLine(arrayB);

