using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Utility 
{
    //Extension method for IEnumerable
    public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
    {
        System.Random rnd = new System.Random();
        return source.OrderBy<T, int>((item) => rnd.Next());
    }
}
