using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static T GetRandomValue<T>(this T[] arr)
    {
        int randomValue = Random.Range(0, arr.Length);
        return arr[randomValue];
    }
}
