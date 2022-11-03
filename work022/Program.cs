// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите координату X первой точки: ");                                       
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y первой точки: ");                                       
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z первой точки: ");                                       
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату X второй точки: ");                                       
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y второй точки: ");                                       
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z второй точки: ");                                       
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);                       // Тиорема пифагора 
Console.WriteLine($"Длинна отрезка {length}");