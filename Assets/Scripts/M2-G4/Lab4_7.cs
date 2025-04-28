using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[20]; 
        GeneraArray(array, 1, 100); 
        StampaArray(array);         
        int somma = SommaArray(array); 
        Debug.Log("Somma degli elementi: " + somma);
    }

   
    void GeneraArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max + 1); 
        }
    }

    int SommaArray(int[] array)
    {
        int somma = 0;

        for (int i = 0; i < array.Length; i++)
        {
            somma += array[i];
        }

        return somma;
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
