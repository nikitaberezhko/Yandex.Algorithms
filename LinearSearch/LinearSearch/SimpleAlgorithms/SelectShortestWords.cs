using System;
using System.Linq;

namespace LinearSearch.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    /// <summary>
    /// Дана последовательность слов
    /// Вывести все самые короткие слова через пробел.
    /// </summary>
    public static string[] SelectShortestWords(string str)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        if (string.IsNullOrWhiteSpace(str)) return [];
    
        var words = str.Split(' ');

        int? minLength = null;
        foreach (var n in words)
            if (n.Length < minLength || minLength == null) 
                minLength = n.Length;

        return words.Where(w => w.Length == minLength).ToArray();
    }
}