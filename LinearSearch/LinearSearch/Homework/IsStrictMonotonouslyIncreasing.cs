using System;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    /// <summary>
    /// Является ли последовательность строго монотонно возрастающей
    /// </summary>
    public static bool IsStrictMonotonouslyIncreasing(int[] array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (array.Length == 0) return true;
        if (array[0] > array[^1]) return false;
        
        var max = array[0];
        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            else
                return false;
        }

        return true;
    }
}