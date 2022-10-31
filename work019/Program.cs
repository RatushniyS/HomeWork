// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
System.Console.WriteLine();

int QuarterNumber = 0;                                                  // Переменная НомерЧетверти
int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
System.Console.WriteLine($"Координаты точки: ({x}, {y})");              // Вывод случайных значений

if (x * y == 0) QuarterNumber = 0;                                      // Условие если точка на оси
else if (x > 0 && y > 0) QuarterNumber = 1;                             // Определяем четверть
else if (x < 0 && y > 0) QuarterNumber = 2;
else if (x < 0 && y < 0) QuarterNumber = 3;
else QuarterNumber = 4;

System.Console.Write($"Точка с координатами ({x}, {y}) находится ");
if (QuarterNumber == 0) System.Console.WriteLine("на одной из оси координат");
else System.Console.WriteLine($"в {QuarterNumber}-й четверти");
System.Console.WriteLine();