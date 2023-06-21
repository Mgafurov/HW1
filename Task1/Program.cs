using System;

class Program
{
    static void Main()
    {
        // Исходный двумерный массив
        int[,] array = {
            { 5, 8, 1, 3 },
            { 4, 2, 9, 7 },
            { 6, 0, 1, 2 }
        };

        // Получаем количество строк и столбцов в массиве
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Проходим по каждой строке массива
        for (int i = 0; i < rows; i++)
        {
            // Создаем временный массив для хранения отсортированных элементов текущей строки
            int[] sortedRow = new int[columns];

            // Копируем элементы текущей строки во временный массив
            for (int j = 0; j < columns; j++)
            {
                sortedRow[j] = array[i, j];
            }

            // Сортируем временный массив по убыванию
            Array.Sort(sortedRow);
            Array.Reverse(sortedRow);

            // Копируем отсортированные элементы обратно в исходный массив
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = sortedRow[j];
            }
        }

        // Выводим отсортированный двумерный массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
