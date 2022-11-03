// Подсчитать сумму цифр в числе

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите Число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

System.Console.Write($"Сумма всех чисел числа {number} = ");

for (int i = 0; i <= number; i++)
{
    int digit = number % 10;
    if (digit == 1)
        sum = sum + 1;
    else
    sum = sum + digit;
    number = number / 10;
}


System.Console.WriteLine(sum);