// Определить количество цифр в числе

// Как сделать возможность ввода более 13 символов // Решено. Conbert.ToInt32 заменил на 64

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите Число");
long number = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine();

long numberDigits = (long) Math.Log10(number) + 1;

System.Console.WriteLine($"Число {number} состоит из {numberDigits} цифр");