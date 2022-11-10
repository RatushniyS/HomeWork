System.Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int[,] desk = new int[n, m];

// int horse = desk[0, 0];             // Конь на позиции 0 0

int[][] step =
    {
        new int[] {2, 1},
        new int[] {1, 2},
        // new int[] {1, -2},              // Куда может шагнуть конь
        // new int[] {2, -1},              // Многомерный массив
        // new int[] {-1, 2},
        // new int[] {2, 1},
        // new int[] {-2, -1},
        // new int[] {-1, -2},

    };
 

void SetHorse(int x, int y)
{
    desk[x, y] = 0;
    for (int i = 0; i < 2; i++)
    {
        desk[x + step[i][0], y + step[i][1]] = i + 1;
    }
}




void PrintDesk(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{desk[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void Main(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            desk[i, j] = 0;
        }
    }
    SetHorse(0, 0);
    PrintDesk(desk);
}

Main(desk);