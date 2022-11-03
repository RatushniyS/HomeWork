//  5. Написать программу вычисления значения функции y = f(a)
// вычислить сумму значений, возвращаемых функцией f() от 1 до x
// Функция будет напримет такая: 4x^3 - 3x^2
// Пытался максимально в этом разобраться, что-то понял, что-то нет. Часть кода скопировал с интернета



static double f(double x)
{
    return 4 * Math.Pow(x, 3) - 3 * Math.Pow(x, 2);
}
Console.WriteLine("Введите X:");
int t = Convert.ToInt32(Console.ReadLine());

int x = Convert.ToInt32(t);
int i;
double sum = 0;

for (i = 1; i <= x; i++)
    sum = sum + f(i);

Console.WriteLine("Результат: {0}", sum);