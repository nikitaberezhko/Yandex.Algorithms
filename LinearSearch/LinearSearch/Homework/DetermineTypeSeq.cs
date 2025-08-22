using System;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    /// <summary>
    /// По последовательности чисел во входных данных определите ее вид:
    /// CONSTANT – последовательность состоит из одинаковых значений
    /// ASCENDING – последовательность является строго возрастающей
    /// WEAKLY ASCENDING – последовательность является нестрого возрастающей
    /// DESCENDING – последовательность является строго убывающей
    /// WEAKLY DESCENDING – последовательность является нестрого убывающей
    /// RANDOM – последовательность не принадлежит ни к одному из вышеупомянутых типов
    /// </summary>
    public static string DetermineTypeSeq(int[] seq)
    {
        if (seq == null) throw new ArgumentNullException(nameof(seq));
        if (seq.Length <= 1) return TypeSequence.Constant;
        
        var canBeConstant = true;
        var canBeAscending = true;
        var canBeWeaklyAscending = true;
        var canBeDescending = true;
        var canBeWeaklyDescending = true;
        
        for (var i = 1; i < seq.Length; i++)
        {
            var diff = seq[i] - seq[i - 1];

            if (diff != 0) canBeConstant = false;
            if (diff <= 0) canBeAscending = false;
            if (diff < 0) canBeWeaklyAscending = false;
            if (diff >= 0) canBeDescending = false;
            if (diff > 0) canBeWeaklyDescending = false;
        }
        
        if (canBeConstant) return TypeSequence.Constant;
        if (canBeAscending) return TypeSequence.Ascending;
        if (canBeWeaklyAscending) return TypeSequence.WeaklyAscending;
        if (canBeDescending) return TypeSequence.Descending;
        if (canBeWeaklyDescending) return TypeSequence.WeaklyDescending;

        return TypeSequence.Random;
    }
    
    public class TypeSequence
    {
        public static readonly string Constant = "CONSTANT";
        public static readonly string Ascending = "ASCENDING";
        public static readonly string WeaklyAscending = "WEAKLY ASCENDING";
        public static readonly string Descending = "DESCENDING";
        public static readonly string WeaklyDescending = "WEAKLY DESCENDING";
        public static readonly string Random = "RANDOM";
    }
}