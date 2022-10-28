// 7. Показать числа от -N до N
Console.WriteLine("Введите число");
string? writeNumber = Console.ReadLine();
System.Console.WriteLine();
int endNumber = Convert.ToInt32(writeNumber);
int Number = endNumber * (-1);
System.Console.WriteLine(Number);

while (Number < endNumber)
{
    Number += 1;
    System.Console.WriteLine(Number);
}
