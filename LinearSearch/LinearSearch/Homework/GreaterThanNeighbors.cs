using System;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    /// <summary>
    /// Дан список чисел. Определите, сколько в этом списке элементов, которые больше двух своих
    /// соседей и выведите количество таких элементов.
    ///
    /// Формат ввода
    /// Вводится список чисел. Все числа списка находятся на одной строке.
    ///
    /// Формат вывода
    /// Выведите ответ на задачу.
    /// </summary>
    public static int GreaterThanNeighbors(int[] array)
    {
        if (array == null) throw new ArgumentException(nameof(array));
        if (array.Length < 3) return 0; 
        
        var count = 0;

        for (var i = 1; i < array.Length - 1; i++)
            if (array[i] > array[i - 1] && array[i] > array[i + 1]) 
                count++;

        return count;
    }
}