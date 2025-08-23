using System;
using System.Collections.Generic;
using System.Linq;

// Считываем n, m, k из первой строки
var firstLine = Console.ReadLine();
var values = firstLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
var n = int.Parse(values[0]);
var m = int.Parse(values[1]);
var k = int.Parse(values[2]);

// Считываем k строк с координатами мин
var mines = new List<(int p, int q)>();
for (var i = 0; i < k; i++)
{
    var mineLine = Console.ReadLine();
    var mineCoords = mineLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var p = int.Parse(mineCoords[0]);
    var q = int.Parse(mineCoords[1]);
    mines.Add((p, q));
}

// Вызываем функцию Сапер и выводим результат
var result = Saper(n, m, k, mines);

// Выводим поле
for (var i = 0; i < n; i++)
{
    for (var j = 0; j < m; j++)
    {
        if (result[i, j] == -1)
        {
            Console.Write("* ");
            continue;
        }
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}

static int[,] Saper(int n, int m, int k, List<(int p, int q)> mines)
{
    const int mine = -1;
    var field = new int[n + 2, m + 2];
    
    int[] dp = new[] { 1, 1, 1, 0, 0, -1, -1, -1 };
    int[] dq = new[] { -1, 0, 1, -1, 1, -1, 0, 1 };
    
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