Console.Clear();
// Создание трехмерного массива
int[,,] array = new int[2, 2, 2];

// Заполнение массива значениями
Random num = new Random();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            array[i, j, k] = num.Next(10, 99);
        }
    }
}

// Вывод массива с добавлением индексов каждого элемента
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write(array[i, j, k]);
            Console.Write("(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}