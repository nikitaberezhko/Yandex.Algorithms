namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public static int? FindLastIndex(int[] array, int target)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));
        
        int? lastIndex = null;
        
        for (var i = 0; i < array.Length; i++)
            if (array[i] == target) lastIndex = i;
        
        return lastIndex;
    }
}