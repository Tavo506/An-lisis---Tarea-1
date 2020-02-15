using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{

    public InputField inp;

    private void QuickSort(int[] arr, int start, int end)
    {
        int i;
        if (start < end)
        {
            i = Partition(arr, start, end);

            QuickSort(arr, start, i - 1);
            QuickSort(arr, i + 1, end);
        }
    }

    private int Partition(int[] arr, int start, int end)
    {
        int temp;
        int p = arr[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (arr[j] <= p)
            {
                i++;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        temp = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = temp;
        return i + 1;
    }

    public void Quick()     //http://csharpexamples.com/c-quick-sort-algorithm-implementation/
    {
        int n = Int32.Parse(inp.text);
        Debug.Log(n);

        int[] arr = new int[10]
        {
            1, 5, 4, 11, 20, 8, 2, 98, 90, 16
        };

        QuickSort(arr, 0, arr.Length - 1);
        Debug.Log("Sorted Values:");
        for (int i = 0; i < arr.Length; i++)
            Debug.Log(arr[i]);
    }

    public void Bubble()    //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
    {
        int n = Int32.Parse(inp.text);
        Debug.Log(n);

        int[] a = { 3, 0, 2, 5, -1, 4, 1 };
        int t;
        Debug.Log("Original array :");
        foreach (int aa in a)
            Debug.Log(aa + " ");
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }
        }
        Debug.Log("\n" + "Sorted array :");
        foreach (int aa in a)
            Debug.Log(aa + " ");
        Debug.Log("\n");
    }
}
