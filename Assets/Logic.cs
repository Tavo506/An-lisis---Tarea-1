using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Logic : MonoBehaviour
{

    private int LIM = 500;
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
        
        for (int n = 2; n <= LIM; n++)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Random.Range(1, 1000);
            }
            DateTime tiempo1 = DateTime.Now;
            QuickSort(arr, 0, arr.Length - 1);
            DateTime tiempo2 = DateTime.Now;
            TimeSpan tiempo = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Debug.Log(tiempo.ToString());
            //for (int i = 0; i < arr.Length; i++)
            //Debug.Log(arr[i]);
            Debug.Log("--------------" + n + "--------------");
        }
    }

    public void Bubble()    //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
    {
        int t;
        for (int n = 2; n <= LIM; n++) {
            //Debug.Log(tomarTiempo);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Random.Range(1, 1000);
            }
            DateTime tiempo1 = DateTime.Now;
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
            DateTime tiempo2 = DateTime.Now;
            TimeSpan tiempo = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Debug.Log(tiempo.ToString());
            //foreach (int aa in a)
                //Debug.Log(aa + " ");
            Debug.Log("--------------" + n + "--------------");

        }
    }


}
