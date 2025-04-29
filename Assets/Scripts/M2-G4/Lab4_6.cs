using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray();
        StampaArray(array);         
        int somma = SommaArray(array); 
        Debug.Log("Somma degli elementi: " + somma);
    }

    public int[] GeneraArray()
    {
        int[] nuovoArray = new int[20];

        for (int i = 0; i < nuovoArray.Length; i++)
        { 
            nuovoArray[i] = Random.Range(1, 101); 
        }

        return nuovoArray;
    }

    public int SommaArray(int[] array)
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
