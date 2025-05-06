using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class Lab5_4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray();
        Debug.Log("Array originale:");
        StampaArray(array);

        
        int[] arrayRidotto = CambiaDimensioneArray(array, 10);
        Debug.Log("Array ridotto a dimensione 10:");
        StampaArray(arrayRidotto);

        int[] arrayEspanso = CambiaDimensioneArray(array, 30);
        Debug.Log("Array espanso a dimensione 30:");
        StampaArray(arrayEspanso);

        
        int[] arrayUguale = CambiaDimensioneArray(array, array.Length);
        Debug.Log("Array con stessa dimensione:");
        StampaArray(arrayUguale);
    }

    int[] CambiaDimensioneArray(int[] arrayOriginale, int nuovaDimensione)
    {
        int dimensioneOriginale = arrayOriginale.Length;

        if (nuovaDimensione < dimensioneOriginale)
        {
            int[] nuovoArray = new int[nuovaDimensione];
            for (int i = 0; i < nuovaDimensione; i++)
            {
                nuovoArray[i] = arrayOriginale[i];
            }
            return nuovoArray;
        }
        else if (nuovaDimensione > dimensioneOriginale)
        {
            int[] nuovoArray = new int[nuovaDimensione];
            for (int i = 0; i < dimensioneOriginale; i++)
            {
                nuovoArray[i] = arrayOriginale[i];
            }
            for (int i = dimensioneOriginale; i < nuovaDimensione; i++)
            {
                nuovoArray[i] = 0;
            }
            return nuovoArray;
        }
        else
        {
            return arrayOriginale;
        }
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
    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Elemento " + i + ": " + array[i]);
        }
    }
    void StampaArray2(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Elemento modificato " + i + ": " + array[i]);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
