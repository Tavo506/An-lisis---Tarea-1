using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Logic : MonoBehaviour
{
    private GameObject esfera;
    public Canvas canvas;
    public Camera camara1, camara2;
    public Image tablaQuick, tablaBubble;
    private static int LIM = 5000, START = 500;
    public ArrayList tiemposQuick, tiemposBubble;

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
        int contador = 1;
        tiemposQuick = new ArrayList();
        for (int n = START; n <= LIM; n += 250)
        {
            
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) //Obtiene los valores aleatorios para la lista
            {
                arr[i] = Random.Range(1, 1000);
            }

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            QuickSort(arr, 0, arr.Length - 1);
            double tiempo = sw.Elapsed.TotalMilliseconds;
            //Debug.Log(tiempo);
            tiemposQuick.Add(tiempo);
            colocarQuick(contador, tiempo);
            contador++;

            //for (int i = 0; i < arr.Length; i++)
            //Debug.Log(arr[i]);
            Debug.Log("--------------" + n + "--------------");
        }
    }

    public void Bubble()    //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
    {
        int contador = 1;
        tiemposBubble = new ArrayList();
        int t;

        for (int n = START; n <= LIM; n += 250) {

            int[] a = new int[n];
            for (int i = 0; i < n; i++) //Obtiene los valores aleatorios para la lista
            {
                a[i] = Random.Range(1, 1000);   
            }
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
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
            double tiempo = sw.Elapsed.TotalMilliseconds;
            //Debug.Log(tiempo);
            tiemposBubble.Add(tiempo);  
            colocarBubble(contador, tiempo);
            contador++;
            //foreach (int aa in a)
            //Debug.Log(aa + " ");
            Debug.Log("--------------" + n + "--------------");

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            canvas.enabled = true;
            camara1.enabled = true;
            camara2.enabled = false;
        }
    }

    public void Iniciar()
    {
        Quick();
        Bubble();
    }

    void colocarQuick(int cantidad, double tiempo)  //Coloca los objetos en la tabla quicksort segun su tiempo
    {
        esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera.transform.SetParent(tablaQuick.transform);

        esfera.transform.localScale = new Vector3(10, 10, 10);
        esfera.transform.position = new Vector3(tablaQuick.transform.position.x + (-630 + 65 * cantidad), tablaQuick.transform.position.y + (-244 + (float)(280 * tiempo)), tablaQuick.transform.position.z);

    }

    void colocarBubble(int cantidad, double tiempo) //Coloca los objetos en la tabla bubblesort segun su tiempo
    {
        esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera.transform.SetParent(tablaBubble.transform);

        esfera.transform.localScale = new Vector3(10, 10, 10);
        esfera.transform.position = new Vector3(tablaBubble.transform.position.x + (-630 + 65 * cantidad), tablaBubble.transform.position.y + (-244 + (float)(2.5 * tiempo)), tablaBubble.transform.position.z);

    }
}
