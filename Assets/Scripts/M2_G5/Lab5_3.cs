
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(12, 1, 100);
        StampaArray(array);
        int min = TrovaMinimo(array);
        {
            Debug.Log("L'elemento minimo è " + min);
        }
        ;
        int max = TrovaMassimo(array);
        {
            Debug.Log("L'elemento più alto è " + max);
        };
        TrovaMassimo2(array);
        TrovaMinimo2(array);
    }
    public int[] GeneraArray(int dimensione, int min, int max)
    {
        int[] nuovoArray = new int[dimensione];

        for (int i = 0; i < dimensione; i++)
        {
            nuovoArray[i] = Random.Range(min, max + 1);
        }

        return nuovoArray;
    }

    public int TrovaMassimo(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    } 
    public int TrovaMinimo(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    public void TrovaMassimo2(int[] array)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2 && num != max1)
            {
                max2 = num;
            }
        }

        if (max2 == int.MinValue)
            Debug.Log("Non esiste un secondo massimo");
        else
            Debug.Log("Il secondo elemento più alto è: " + max2);
    }
    public void TrovaMinimo2(int[] array)
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];
            if (num < min1)
            {
                min2 = min1;
                min1 = num;
            }
            else if (num < min2 && num != min1)
            {
                min2 = num;
            }
        }

        if (min2 == int.MaxValue)
            Debug.Log("Non esiste un secondo minimo");
        else
            Debug.Log("Il secondo elemento più basso è: " + min2);
    }

    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Elemento " + i + ": " + array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
