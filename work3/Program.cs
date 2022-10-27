// По заданному номеру дня недели вывести его название

System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

System.Console.WriteLine("Введите номер дня недели:   ");
int writeDay = Convert.ToInt32(Console.ReadLine());

if (writeDay > 7)
{
        System.Console.WriteLine("Число указано не верно");
}
else
{
    System.Console.WriteLine(Days[writeDay - 1]);
}
