// Показать четные числа от 1 до N
Console.WriteLine("Введите число");                 // Вводим значение
string? WriteNumber = System.Console.ReadLine();    // Присваиваем    
int EndNumber = Convert.ToInt32(WriteNumber);       // Присваиваем
int FirstNumber = 2;                                // Присваиваем
System.Console.WriteLine();                         // Для красоты делаем пустую строку 
while (FirstNumber <= EndNumber)                    // До тех пор пока первое меньше или ровно второму, делай
{
    Console.WriteLine(FirstNumber);                 // Вывод первого
    FirstNumber += 2;                               // Первое  =  первое  +  2
}
