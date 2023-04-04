Console.Clear();
// Создание массива
int[,] array = new int[4, 4];
int value = 1;
// Границы спирального обхода
int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

// Заполнение массива в порядке обхода.
while (rowStart <= rowEnd && colStart <= colEnd)
{
    // Верхняя строка слева направо
    for (int i = colStart; i <= colEnd; i++)
    {
        array[rowStart, i] = value++;
    }
    rowStart++;

    // Правый столбец сверху вниз
    for (int i = rowStart; i <= rowEnd; i++)
    {
        array[i, colEnd] = value++;
    }
    colEnd--;

    // Нижняя строка справа налево
    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = value++;
        }
        rowEnd--;
    }

    // Левый столбец снизу вверх
    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = value++;
        }
        colStart++;
    }
}

// Вывод
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0:d2} ", array[i, j]);
    }
    Console.WriteLine();
}