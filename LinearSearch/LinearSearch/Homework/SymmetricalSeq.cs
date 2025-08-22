using System;
using System.Collections.Generic;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    /// <summary>
    /// Последовательность чисел назовем симметричной, если она одинаково читается как слева
    /// направо, так и справа налево. Например, следующие последовательности являются
    /// симметричными:
    /// 1 2 3 4 5 4 3 2 1
    /// 1 2 1 2 2
    ///[0 1 2 3 4 5 6]
    /// 5 5 5 5
    /// Вашей программе будет дана последовательность чисел. Требуется определить,
    /// какое минимальное количество и каких чисел надо приписать в конец этой последовательности,
    /// чтобы она стала симметричной.
    /// </summary>
    public static AddingToSequence SymmetricalSeq(int[] array)
    {
        
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (array.Length < 3) return new AddingToSequence { QuantityForAdd = 0, NumbersForAdd = null };

        for (var start = 0; start < array.Length; start++)
        {
            var i = start;
            var j = array.Length - 1;

            while (i < array.Length && j > 0 && array[i] == array[j] && i <= j)
            {
                i++;
                j--;
            }
            
            if (i > j)
            {
                var list = new List<int>();
                for (var k = start - 1; k >= 0; k--)
                {
                    list.Add(array[k]);
                }
                
                return new AddingToSequence
                {
                    QuantityForAdd = list.Count,
                    NumbersForAdd = list.ToArray()
                };
            }
        }
        
        return new AddingToSequence
        {
            QuantityForAdd = 0,
            NumbersForAdd = Array.Empty<int>()
        };
    }

    public struct AddingToSequence
    {
        public int QuantityForAdd { get; set; }
        public int[]? NumbersForAdd { get; set; }
    }
}