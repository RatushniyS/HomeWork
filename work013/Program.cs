// Выяснить, кратно ли число заданному, если нет, вывести остаток

int number1 = new Random().Next(10, 100);                                                        // Задаем рандомные значения
int number2 = new Random().Next(1, 10);                                                          // 

System.Console.WriteLine($"Первое число {number1}");                                             // Показывает какие значения сгенерировались
System.Console.WriteLine($"Второе число {number2}");                                                      

System.Console.WriteLine();                                                                      // Пустая строка

if (number1 % number2 == 0)                                                                      // Если number1 делится без остатка на number2
{
    System.Console.WriteLine($"Число {number1} делится на число {number2} без остатка");         // Вывод
}
else                                                                                             
{
    System.Console.WriteLine($"Число {number1} при делении на {number2} делится не полностью, остаток: {number1 % number2}");                         // Вывод
}