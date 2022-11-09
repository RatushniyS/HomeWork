// // Задача 53: Задайте двумерный массив. 
// // Напишите программу, которая поменяет местами первую и последнюю строку
// // массива

// // Задача 55: Задайте двумерный массив. 
// // Напишите программу, которая заменяет строки на столбцы.
// //  В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// // **Задача HARD SORT ** 
// // Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 10 3

// // После сортировки
// // 1 2 3 4
// // 5 7 9 10






// int InputArray(string variable)
// {
//     Console.WriteLine($"Введите {variable}");
//     int res = Convert.ToInt32(Console.ReadLine());
//     return res;
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 20);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }

// }


// // int[] ConvertToList(int[,] array)    //В одномерный массив
// // {
// //     int[] array1 = new int[array.GetLength(0) * array.GetLength(1)];

// //     int m = 0;

// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             array1[m] = array[i, j];
// //             m++;
// //         }
// //     }
// //     return array1;
// // }

// void BubblerSort(int[,] array)
// {
//     int x = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 for (int l = 0; l < array.GetLength(1); l++)
//                 {
//                     if (array[i, j] <= array[k, l])
//                     {
//                         x = array[i, j];
//                         array[i, j] = array[k, l];
//                         array[k, l] = x;
//                     }

//                 }
//             }

//         }
//     }
// }




// // void SortArray2(int[,] array)

// // void ChangeLine(int[,] array)
// // {

// //     for (int j = 0; j < array.GetLength(1); j++)
// //     {

// //         (array[array.GetLength(0) - 1, j], array[0, j]) = (array[0, j], array[array.GetLength(0) - 1, j]);
// //         //         // int temp = array[array.GetLength(0) - 1, j];
// //         //         // array[array.GetLength(0) - 1, j] = array[0, j];
// //         //         // array[0, j] = temp;
// //     }
// // }

// // // // int temp = array[array.GetLength(0) - 1, j];


// int i = InputArray("количество строк");
// int j = InputArray("количество столбцов");
// System.Console.WriteLine();
// int[,] matrix = new int[i, j];
// FillArray(matrix);
// PrintArray(matrix);

// // ChangeLine(matrix);
// System.Console.WriteLine();
// // PrintArray(matrix);
// int[] array1 = new int[i * j];   //создаем одномерный. Длинна = i*j
// int[] list = ConvertToList(matrix);

// System.Console.Write(list);


