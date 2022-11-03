// Определить количество цифр в числе

// Как сделать возможность ввода более 13 символов

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите Число");
int number = Convert.ToInt32(Console.ReadLine());

int numberDigits = (int) Math.Log10(number) + 1;

System.Console.WriteLine($"Число {number} состоит из {numberDigits} цифр");