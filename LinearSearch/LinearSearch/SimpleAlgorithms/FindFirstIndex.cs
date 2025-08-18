namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public static int? FindFirstIndex(int[] array, int target)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));

        for (var i = 0; i < array.Length; i++)
            if (array[i] == target) return i;

        return null;
    }
    
    public static int FindLastIndex(int[] array, int target)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));
        
        var index = 0;
        
        for (var i = 0; i < array.Length; i++)
            if (array[i] == target) index = i;
        
        return index;
    }
}