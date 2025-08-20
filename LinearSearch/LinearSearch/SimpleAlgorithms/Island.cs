namespace LinearSearch.SimpleAlgorithms;

public partial class SimpleAlgorithms
{
    public static int CalculateWaterSquares(int[] heights)
    {
        if (heights == null) throw new ArgumentNullException(nameof(heights));
        if (heights.Length == 0) return 0;
        var waterSquares = 0;

        var highest = 0;

        for (var i = 0; i < heights.Length; i++)
            if (heights[i] > heights[highest])
                highest = i;

        var currentMax = 0;
        for (var i = 0; i < highest; i++)
        {
            if (heights[i] > currentMax)
                currentMax = heights[i];
            
            if (heights[i] < currentMax)
                waterSquares += currentMax - heights[i];
        }

        currentMax = 0;
        for (var i = heights.Length - 1; i > highest; i--)
        {
            if (heights[i] > currentMax)
                currentMax = heights[i];
            
            if (heights[i] < currentMax)
                waterSquares += currentMax - heights[i];
        }

        return waterSquares;
    }
}