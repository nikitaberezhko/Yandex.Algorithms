using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.SimpleAlgorithms;

public static partial class SimpleAlgorithms
{
    /// <summary>
    /// Дан словарь из N слов, длина каждого не превосходит K
    /// В записи каждого из М слов текста (каждое длиной до К) может быть пропущена одна буква.
    /// Для каждого слова сказать, входит ли оно (возможно, с одной пропущенной буквой), в словарь
    /// </summary>
    public static List<(string words, bool found)> MissingLetter(string[] dictionary, string[] words)
    {
        if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
        if (words == null) throw new ArgumentNullException(nameof(words));

        if (dictionary.Length == 0) throw new ArgumentOutOfRangeException(nameof(dictionary));
        if (words.Length == 0) throw new ArgumentOutOfRangeException(nameof(words));

        var result = new List<(string words, bool found)>();  
        var set = new HashSet<string>();

        foreach (var word in dictionary)
        foreach (var variant in CalculateAllMissingVariants(word))
            set.Add(variant);

        foreach (var word in words)
            result.Add(set.Contains(word) 
                ? (word, true) 
                : (word, false));
        
        return result;
    }

    private static string[] CalculateAllMissingVariants(string word)
    {
        var variants = new List<string> { word };
        
        variants.AddRange(word.Select((_, i) => word.Remove(i, 1)));

        return variants.ToArray();
    }
}