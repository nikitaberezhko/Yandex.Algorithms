using System;

namespace LinearSearch.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    public static MaxPair FindMaxPair(int[] array)
    {
        if (array ==  null) throw new ArgumentNullException(nameof(array));
        if (array.Length < 2) throw new ArgumentOutOfRangeException(nameof(array));
        
        var max = array[0] > array[1] 
            ? array[0] 
            : array[1];
        var secondMax = array[0] < array[1] 
            ? array[0] 
            : array[1];

        for (var i = 2; i < array.Length; i++)
        {
            if (array[i] > secondMax) secondMax = array[i];
            if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
            }
        }

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