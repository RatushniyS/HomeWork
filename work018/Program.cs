// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// X = { 0|1 }
// Y = { 0|1 }

// ¬(0 ⋁ 0) = ¬0 ⋀ ¬0   => 1 = 1 => 1
// ¬(0 ⋁ 1) = ¬0 ⋀ ¬1   => 
// ¬(1 ⋁ 0) = ¬1 ⋀ ¬0   =>
// ¬(1 ⋁ 1) = ¬1 ⋀ ¬1   =>

// Устал я с этм разбираться, частично загуглил решение

int a = new Random().Next(1, 10);
System.Console.WriteLine($"x = {a}");
int b = new Random().Next(1, 10);
System.Console.WriteLine($"y = {b}");
int x = a;
int y = b;

bool XY = x != a || y == b;
bool notXY = XY != true;
bool notXnotY = x != a | y != b;

System.Console.WriteLine(notXnotY);
System.Console.WriteLine(notXY);

if (notXY == notXnotY) System.Console.WriteLine("Утвеждение истинно");
else System.Console.WriteLine("Утверждение ложно");
System.Console.WriteLine();