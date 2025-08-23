using System.Collections.Generic;

namespace LinearSearch.Homework;

public static partial class HomeworkAlgorithms
{
    /// <summary>
    /// Выведите построенное поле, разделяя строки поля переводом строки, а столбцы - пробелом.
    /// </summary>
    /// <param name="n"><1≤N≤100 - количество строк на поле/param>
    /// <param name="m">1≤M≤100 - количество столбцов на поле</param>
    /// <param name="k">0≤K≤N⋅M - количество мин на поле</param>
    /// <param name="mines">В следующих K строках содержатся по два числа с координатами мин (p - строка, q - столбец)</param>
    /// <param name="m"></param>
    /// <param name="k"></param>
    /// <param name="mines"></param>
    public static int[,] Saper(int n, int m, int k, List<(int p, int q)> mines)
    {
        const int mine = -1;
        var field = new int[n + 2, m + 2];
        
        int[] dp = [1, 1, 1, 0, 0, -1, -1, -1];
        int[] dq = [-1, 0, 1, -1, 1, -1, 0, 1];
        
        foreach (var (p, q) in mines)
        {
            field[p, q] = mine;
            for (var i = 0; i < 8; i++)
                if (field[p + dp[i], q + dq[i]] != -1) 
                    field[p + dp[i], q + dq[i]]++;
        }
        
        var result = new int[n, m];
        for (var i = 0; i < n; i++)
        for (var j = 0; j < m; j++) 
            result[i, j] = field[i + 1, j + 1];
        
        return result;
    }
}