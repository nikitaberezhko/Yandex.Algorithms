using System;
using System.Text;

namespace LinearSearch;

public static class Rle
{
    public static string Compress(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        if (input.Length == 0) return string.Empty;

        var builder = new StringBuilder();
        var current = input[0];
        var count = 1;

        for (var i = 1; i < input.Length; i++)
            if (input[i] == current) 
                count++;
            else if (count > 1)
            {
                builder.Append($"{current}{count}");
                count = 1;
                current = input[i];
            }
            else
            {
                builder.Append(current);
                current = input[i];
            }
        
        // Добавляем последний символ или символ с количеством
        if (count > 1)
            builder.Append($"{current}{count}");
        else
            builder.Append(current);
                

        return builder.ToString();
    }
}