// Программа проверяет пятизначное число на палиндромом.
// Гугл помог понять как и что такое палиндром))))

System.Console.Write("Введите целое число:   ");
string? number = Console.ReadLine();
int length = number!.Length;

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine($"Введный текст/число - {number} - является палиндромом");
else System.Console.WriteLine($"Число {number} не является палиндромом");
System.Console.WriteLine();