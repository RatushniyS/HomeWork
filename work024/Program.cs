// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int degree = 3;

System.Console.WriteLine();

for (int i = 1; i <= number; i++)
{

    Console.Write(Math.Pow(i, degree) + " ");    // WriteLine Если захотим в столбик ( вычисление степени )
}