// Программа проверяет пятизначное число на палиндромом.


Console.Clear();
System.Console.WriteLine();


System.Console.WriteLine("Введите пятизначное число число: ");
string number = Console.ReadLine();
int lenght = number.Length;

if (lenght == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"Число {number} - является палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {number} - НЕ является палиндромом");
    }
}
else
{
    System.Console.WriteLine($"Введите корректное число");
}