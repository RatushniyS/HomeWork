// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 задаются пользователем

Console.Clear();
System.Console.WriteLine();

double input(string variable) 
{ 
       Console.WriteLine($"введите число {variable}"); 
       double res = Convert.ToInt64(Console.ReadLine()); 
       return res; 
} 
 
double b1 = input("b1");
double k1 = input("k1");
double b2 = input("b2");
double k2 = input("k2");

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

// x = Math.Round(x, 2);                                       // Чтоб не городить кучу цифр после запятой, округлим. Получится не точно, так как точка пересечения сместится
// y = Math.Round(y, 2);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");