using System;

class Program
{
    static void Main()
    {
        // Исходные матрицы
        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matrix2 = {
            { 10, 11 },
            { 12, 13 },
            { 14, 15 }
        };

        // Получаем количество строк и столбцов в матрицах
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        // Проверяем, возможно ли умножение матриц
        if (columns1 != rows2)
        {
            Console.WriteLine("Невозможно выполнить умножение матриц.");
            return;
        }

        // Создаем новую матрицу для хранения результата умножения
        int[,] resultMatrix = new int[rows1, columns2];

        // Выполняем умножение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;

                for (int k = 0; k < columns1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                resultMatrix[i, j] = sum;
            }
        }

        // Выводим результат умножения
        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
