// Найти максимальное из трех чисел

System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximal = Math.Max(Math.Max(number1, number2), number3);

Console.WriteLine("Максимальное число ->"   +   maximal);