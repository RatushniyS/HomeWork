//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

System.Console.WriteLine("Введите число для проверки");         // ввод числа
int number = Convert.ToInt32(Console.ReadLine());               // Присваиваем написанное к number
if (number % 2 != 0)                                            // Если number делится на 2 без остатка, то
    System.Console.WriteLine("Число не является четным");       // Вывод
else                                                            // Иначе
    System.Console.WriteLine("Число является четым");           // Вывод