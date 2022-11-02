// Показать таблицу квадратов чисел от 1 до N 

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int degree = 2;

System.Console.WriteLine();

for (int i = 1; i <= number; i++)
{

    Console.Write(Math.Pow(i, degree) + " ");
}