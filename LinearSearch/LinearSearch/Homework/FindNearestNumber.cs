using System;

namespace LinearSearch.Homework;

public partial class HomeworkAlgorithms
{
    /// <summary>
    /// Напишите программу, которая находит в массиве элемент, самый близкий по величине к  данному числу.
    ///
    /// Формат ввода
    /// В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.
    /// Во второй строке содержатся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).
    /// В третьей строке вводится одно целое число x, не превосходящее по модулю 1000.
    ///
    /// Формат вывода
    /// Вывести значение элемента массива, ближайшее к x. Если таких чисел несколько, выведите любое из них.
    /// </summary>
    public static int FindNearestNumber(int[] array, int target)
    {
        if (array == null) throw new ArgumentException(nameof(array));
        if (array.Length == 0) throw new ArgumentException("Array cannot be empty", nameof(array));
        
        var nearest = Math.Abs(array[0] - target);
        var nearestIndex = 0;

        for (var i = 1; i < array.Length; i++)
        {
            var diff = Math.Abs(array[i] - target);
            
            if (diff < nearest)
            {
                nearest = diff;
                nearestIndex = i;
            }
        }
        
        return array[nearestIndex];
    }
}