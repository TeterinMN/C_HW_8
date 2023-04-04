// Функция для подсчета количества цифр в числе
static int CountDigits(int n)
{
    int count = 0;
    while (n != 0)
    {
        count++;
        n /= 10;
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

// Создаем двумерный массив для хранения значений треугольника Паскаля
int[,] pascal = new int[n, n];

// Заполняем первую строку единицами
for (int i = 0; i < n; i++)
{
    pascal[0, i] = 1;
}

// Заполняем остальные строки значениями треугольника Паскаля
for (int i = 1; i < n; i++)
{
    pascal[i, 0] = 1;
    for (int j = 1; j < n; j++)
    {
        pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
    }
}

// Определяем максимальное значение в последней строке треугольника Паскаля
int maxVal = pascal[n - 1, (n - 1) / 2];

// Выводим треугольник Паскаля в виде равнобедренного треугольника
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        int val = pascal[i, j];
        int digits = CountDigits(maxVal) - CountDigits(val);
        Console.Write(new string(' ', digits / 2));
        Console.Write(val);
        Console.Write(new string(' ', digits / 2 + digits % 2));
        Console.Write(" ");
    }
    Console.WriteLine();
}