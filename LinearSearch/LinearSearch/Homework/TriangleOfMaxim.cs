using System;
using System.Collections.Generic;

namespace LinearSearch.Homework;

public partial class HomeworkAlgorithms
{
    /// <summary>Определяет интервал возможных значений частоты звучания треугольника Максима.</summary>
    /// <remarks>Максим показал запись, в которой приведена последовательность частот,
    /// выставляемых им на тюнере, и про каждую ноту, начиная со второй, записано - ближе или дальше
    /// она к звуку треугольника, чем предыдущая нота. Заранее известно, что частота звучания
    /// треугольника Максима составляет не менее 30 герц и не более 4000 герц.
    ///
    /// Формат ввода: Первая строка содержит целое число n - количество нот
    /// (2 &lt;= n &lt;= 1000). Последующие n строк содержат записи Максима: вещественное число f_i - частоту
    /// в герцах (30 &lt;= f_i &lt;= 4000) и слово "closer" или "further" для каждой частоты, кроме первой.
    /// Логика:
    /// - "closer" означает |f_i - f_triangle| &lt; |f_{i-1} - f_triangle|
    /// - "further" означает, что частота данной ноты дальше, чем предыдущая
    /// - Если нота так же близка, то может быть записано любое из слов
    ///
    /// Формат вывода: Два вещественных числа - наименьшее и наибольшее возможное значение частоты
    /// треугольника с точностью не хуже 10^(-6).</remarks>
    /// <param name="comparisons">Массив частот и их сравнений с треугольником</param>
    /// <returns>Кортеж (minFrequency, maxFrequency) — интервал возможных значений частоты треугольника</returns>
    public static (double, double) TriangleOfMaxim(List<(int frequency, string result)> comparisons)
    {
        const string closer = "closer";
        const string further = "further";
        
        var left = 30.0; 
        var right = 4000.0;

        for (var i = 1; i < comparisons.Count; i++)
        {
            var prev = comparisons[i - 1];
            var now = comparisons[i];

            if (now.result == closer && now.frequency > prev.frequency) 
                left = Math.Max(left, (prev.frequency + now.frequency) / 2);
            
            if (now.result == closer && now.frequency < prev.frequency) 
                right = Math.Min(right, (prev.frequency + now.frequency) / 2);
            
            if (now.result == further && now.frequency < prev.frequency) 
                left = Math.Max(left, (prev.frequency + now.frequency) / 2);
            
            if (now.result == further && now.frequency > prev.frequency) 
                right = Math.Min(right, (prev.frequency + now.frequency) / 2);
        }

        return (left, right);
    }
}