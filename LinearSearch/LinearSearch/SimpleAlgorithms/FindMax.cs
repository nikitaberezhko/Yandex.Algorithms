namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public int? FindMax(int[] array)
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