using System.Collections.Generic;
using System.Linq;

namespace Set.Homework;

public static partial class HomeworkAlgorithms
{
    public static List<int> UnionOfSets(int[] setA, int[] setB)
    {
        var a = new HashSet<int>(setA);
        var b = new HashSet<int>(setB);
        
        var result = new List<int>();

        foreach (var number in a)
            if (b.Contains(number)) 
                result.Add(number);
        
        return result.OrderBy(x => x).ToList();
    }
}