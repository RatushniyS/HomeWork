// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
System.Console.WriteLine();


System.Console.WriteLine("Введите Число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] GetEvenCubeArray(int N)                           // Метод создания массива и возведеник в куб четных чисел
{
    int num = 1;
    int i = 0;
    int[] EvenCubs = new int[N];
    while (num <= N)
    {
        int cube = num * num * num;
        if (cube % 2 == 0)
        {
            EvenCubs[i] = cube;
            i++;
        }
        num++;
    }
    return EvenCubs;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)                                
        break;                                          // Остановка если четные числа закончились. Чтобы не заполнять массив нулями
        System.Console.Write($"{arr[i]} ");
    }

}

PrintArray(GetEvenCubeArray(N));                        // вызов метода