using System;

class Program
{
    static void Main()
    {
        // Создаем трехмерный массив размером 2 x 2 x 2
        int[,,] array = new int[2, 2, 2];

        int num = 10; // Начальное значение для заполнения массива

        // Заполняем массив неповторяющимися двузначными числами
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num++;
                }
            }
        }

        // Выводим массив построчно с добавлением индексов каждого элемента
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"array[{i}][{j}][{k}] = {array[i, j, k]}");
                }
            }
        }
    }
}
