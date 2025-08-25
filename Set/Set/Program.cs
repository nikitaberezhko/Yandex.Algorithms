using System;
using System.Collections.Generic;
using System.Linq;

var setA = Console.ReadLine().Split().Select(int.Parse).ToArray();
var setB = Console.ReadLine().Split().Select(int.Parse).ToArray();

var result = UnionOfSets(setA, setB);

Console.WriteLine(string.Join(" ", result));
static List<int> UnionOfSets(int[] setA, int[] setB)
{
    var a = new HashSet<int>(setA);
    var b = new HashSet<int>(setB);
        
    var result = new List<int>();

    foreach (var number in a)
        if (b.Contains(number)) 
            result.Add(number);
        
    return result.OrderBy(x => x).ToList();
}