// По двум заанным числам проверять является ли первое квадратом второго
System.Console.WriteLine("Number1");
int Number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Number2");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 == Number2 * Number2)
{
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("NO");
}