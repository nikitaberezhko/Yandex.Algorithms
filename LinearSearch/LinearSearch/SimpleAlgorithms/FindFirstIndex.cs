namespace LinearSearch.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    public static int? FindFirstIndex(int[] array, int target)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));

        for (var i = 0; i < array.Length; i++)
            if (array[i] == target) return i;

        return null;
    }
    
}