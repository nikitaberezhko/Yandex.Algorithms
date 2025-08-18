namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public static int? FindMinEven(int[] array)
    {
        if (array ==  null) throw new ArgumentNullException(nameof(array));
        if  (array.Length == 0) return null;

        int? evenMin = null; 

        foreach (var n in array)
            if (n % 2 == 0 && (evenMin == null || n < evenMin)) 
                evenMin = n;
        
        return evenMin;
    }
}