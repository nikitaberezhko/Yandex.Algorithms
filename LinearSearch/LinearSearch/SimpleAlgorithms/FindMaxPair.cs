namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public MaxPair FindMaxPair(int[] array)
    {
        if (array ==  null) throw new ArgumentNullException(nameof(array));
        if (array.Length < 2) throw new ArgumentOutOfRangeException(nameof(array));
        
        var max = array[0] > array[1] 
            ? array[0] 
            : array[1];
        var secondMax = array[0] < array[1] 
            ? array[0] 
            : array[1];

        foreach (var t in array)
            if (t > max) max = t;
            else if (t > secondMax) secondMax = t;

        return new MaxPair
        {
            Max = max,
            SecondMax = secondMax
        };
    }
    
    public struct MaxPair
    {
        public int Max;
        public int SecondMax;
    }
}