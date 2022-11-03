﻿// Решение в группах задач:

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21





// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Console.Clear();
// System.Console.WriteLine();

// int [] array1 = {-4, -8, 8, 2};
// int [] array2 = array1;
// int lenght = 4;

// for (int i = 0; i < lenght; i++)
// {
//     System.Console.Write($"{array1[i]}  ");
// }

// System.Console.WriteLine();
// System.Console.WriteLine($"Перевернутый массив:  ");

// for (int i = 0; i < lenght; i++)
// {
//     array2[i] = array1[i]*-1;

//     System.Console.Write($"{array1[i]}  ");
//     // System.Console.Write($"{array2[i]}  ");
// }



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Clear();
// System.Console.WriteLine();

// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int [] array = {6, 7, 19, 345, 3};

// int count = 5;

// string result = "Нет";

// for (int i = 0; i < count; i++)
// {
//     System.Console.Write($"{array[i]}  ");
// }

// System.Console.WriteLine(

// );
// for (int i = 0; i < count; i++)
// {
//     if (array[i] == n)
//     result = "ЕСТЬ";
//     break;
// }
// System.Console.WriteLine($"Число {n}  в массиве {result} ");



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Console.Clear();
System.Console.WriteLine();

int[] CreateRandomArray(int n)

{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

int n = 123;

int[] array = CreateRandomArray(n);

int count = 0;
for (int i = 0; i < n; i++)
{
    if (10 > array[i] || array[i] > 100)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine($" Чисел совпавших с диапозоном: {count}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Console.Clear();
// System.Console.WriteLine();

// int[] randomArray(int n)

// {
//     int[] array = new int[n];
//     Random rand = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = rand.Next(0, 100);
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }

// System.Console.WriteLine("Введите количесво элементов массива");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = randomArray(n);


// if (n % 2 ==0)



