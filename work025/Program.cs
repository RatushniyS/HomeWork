// Найти сумму чисел от 1 до А

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = 0;

for (int i = 0; i < number + 1; i++)
{
    sumNumber = sumNumber + i;
}

System.Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");