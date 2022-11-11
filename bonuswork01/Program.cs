﻿System.Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int[,] board = new int[n, m];
int[][] step =
    {
        new int[] {1, 2},
        new int[] {1, -2},              // Куда может шагнуть конь
        new int[] {2, 1},
        new int[] {2, -1},              // Многомерный массив
        new int[] {-1, 2},
        new int[] {-1, -2},
        new int[] {-2, 1},
        new int[] {-2, -1},
    };
int moves;

bool SetHorse(int x, int y)
{
    // Проверка параметров
    if ((x < 0) || (x >= n) || (y < 0) || (y >= n))
        return false;

    if (board[x, y] != 0)
        return false;

    // Остановка
    if (moves == n * m - 1)
        return true;
    // следующий ход
    moves++;
    board[x, y] = moves;
    for (int i = 0; i < 8; i++)
    {
        if (SetHorse(x + step[i][0], y + step[i][1]))
            return true;

        // возврат хода

        moves--;
        board[x, y] = 0;
    }


    return false;
}

void PrintBoard(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{board[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void NoName(int[,] array)
{
    moves = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            board[i, j] = 0;
        }
    }
    SetHorse(0, 0);
    PrintBoard(board);
}

NoName(board);