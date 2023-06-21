using System;

class Program
{
    static void Main()
    {
        // Исходный прямоугольный двумерный массив
        int[,] array = {
            { 5, 8, 1, 3 },
            { 4, 2, 9, 7 },
            { 6, 0, 1, 2 }
        };

        // Получаем количество строк и столбцов в массиве
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Инициализируем переменные для хранения индекса строки с наименьшей суммой и самой маленькой суммы
        int minSumRowIndex = 0;
        int minSum = int.MaxValue;

        // Проходим по каждой строке массива и считаем сумму элементов
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }

            // Если текущая сумма меньше минимальной, обновляем значения
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        // Выводим строку с наименьшей суммой элементов
        Console.WriteLine("Строка с наименьшей суммой элементов: ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[minSumRowIndex, j] + " ");
        }
        Console.WriteLine();

        // Выводим сумму элементов в этой строке
        Console.WriteLine("Сумма элементов: " + minSum);
    }
}
