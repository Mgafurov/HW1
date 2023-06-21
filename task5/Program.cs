using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер N для массива N x N: ");
        int N = int.Parse(Console.ReadLine());

        int[,] array = new int[N, N];

        int value = 1; // Значение для заполнения массива

        int rowStart = 0; // Начальная строка
        int rowEnd = N - 1; // Конечная строка
        int colStart = 0; // Начальный столбец
        int colEnd = N - 1; // Конечный столбец

        while (value <= N * N)
        {
            // Заполнение верхней строки слева направо
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = value++;
            }
            rowStart++;

            // Заполнение правого столбца сверху вниз
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = value++;
            }
            colEnd--;

            // Заполнение нижней строки справа налево
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;

            // Заполнение левого столбца снизу вверх
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }

        // Вывод массива
        Console.WriteLine("Результат заполнения спирального массива:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
