// Найти максимальное из трех чисел

System.Console.WriteLine("Введите первое число");       // Ввод 1 чилсо
int number1 = Convert.ToInt32(Console.ReadLine());      // Считываем набранное, присваиваем
System.Console.WriteLine("Введите второе число");       // Ввод 2 число
int number2 = Convert.ToInt32(Console.ReadLine());      // Считываем набранное, присваиваем
System.Console.WriteLine("Введите третье число");       // Ввод 3 число
int number3 = Convert.ToInt32(Console.ReadLine());      // Считываем набранное, присваиваем

int maximal = Math.Max(Math.Max(number1, number2), number3);  // Присваивам maximal наибольшее

Console.WriteLine("Максимальное число ->"   +   maximal);     // Вывод maximal