using System;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    public static (int, int) LargestMultiplicationTwoNumbers(int[] array)
    {
        if (array ==  null) throw new ArgumentNullException(nameof(array));
        if (array.Length < 2) throw new ArgumentOutOfRangeException(nameof(array));
        
        var first = array[0];
        var second = array[1];
        
        var max = first > second ? first : second;
        var secondMax = first < second ? first : second;

        for (var i = 2; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
            }
            else if (array[i] > secondMax) secondMax = array[i];
        }

        var maxMultiplication = max * secondMax;
        
        var negativeMax = first < second ? first : second;
        var negativeSecondMax = first > second ? first : second;

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] >= 0) continue;
            
            if (array[i] < negativeMax)
            {
                negativeSecondMax = negativeMax;
                negativeMax = array[i];
            }
            else if (array[i] < negativeSecondMax) 
                negativeSecondMax = array[i];
        }
        
        var negativeMultiplication = negativeMax * negativeSecondMax;

        return maxMultiplication > negativeMultiplication 
            ? (Math.Min(max, secondMax), Math.Max(max, secondMax)) 
            : (Math.Min(negativeMax, negativeSecondMax), Math.Max(negativeMax, negativeSecondMax));
    }
}