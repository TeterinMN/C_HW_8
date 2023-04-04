// Метод для вывода массива в консоль
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
// Создание двумерного массива
int[,] array = new int[,]
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

// Исходный массив
Console.WriteLine("Исходный массив:");
PrintArray(array);

// Поиск строки с наименьшей суммой элементов
int minRowIndex = 0;
int minRowSum = int.MaxValue;
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        minRowIndex = i;
    }
}

// Вывод
Console.WriteLine("Строка с наименьшей суммой элементов: " + (minRowIndex + 1));