// Вспомогательный метод для вывода матрицы в консоль
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
// Создание двух матриц
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 4 } };
int[,] matrix2 = new int[,] { { 3, 2 }, { 3, 3 } };

// Исходные матрицы
Console.WriteLine("Исходные матрицы:");
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

// Поиск произведения матриц
int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        resultMatrix[i, j] = sum;
    }
}

// Вывод
Console.WriteLine("Произведение матриц:");
PrintMatrix(resultMatrix);