namespace LinearSearch.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    public static int? FindLastIndex(int[] array, int target)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));
        
        for (var i = array.Length - 1; i >= 0; i--)
            if (array[i] == target) return i;
        
        return null;
    }
}