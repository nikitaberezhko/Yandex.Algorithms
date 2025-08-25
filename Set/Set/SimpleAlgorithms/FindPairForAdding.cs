using System;
using System.Collections.Generic;

namespace Set.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    /// <summary>
    /// Дана последовательность положительных чисел длиной N и число Х
    /// Нужно найти два РАЗЛИЧНЫХ числа А и В из последовательности,
    /// таких что А + В = Х или вернуть пару 0, 0, если такой пары чисел нет
    /// </summary>
    public static (int, int) FindPairForAdding(int[] array, int targetSum)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (array.Length < 2) return (0, 0);
        
        var set = new HashSet<int>();
        
        foreach (var n in array)
            if (set.Contains(targetSum - n) && n != targetSum - n)
                return (n, targetSum - n);
            else
                set.Add(n);

        return (0, 0);
    }
}