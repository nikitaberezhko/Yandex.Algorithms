using System;

namespace LinearSearch.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    public static int? FindMax(int[] array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (array.Length == 0) return null;

        var max = array[0];

        foreach (var t in array)
            if (t > max)
                max = t;

        return max;
    }
}