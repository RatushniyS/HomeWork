// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
System.Console.WriteLine();

int quarterNumber = new Random().Next(1, 5);
string range = "";

if (quarterNumber == 1) range = "x > 0, y > 0";
else if (quarterNumber == 2) range = "x < 0, y > 0";
else if (quarterNumber == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

System.Console.WriteLine($"Для {quarterNumber}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
System.Console.WriteLine();