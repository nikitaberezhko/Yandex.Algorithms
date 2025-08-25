using System.Collections.Generic;

namespace Set.Homework;

public static partial class HomeworkAlgorithms
{
    public static int QuantityDifferentNumbers(int[] numbers)
    {
        var set = new HashSet<int>();
        
        foreach (var number in numbers) 
            set.Add(number);

        return set.Count;
    }
}