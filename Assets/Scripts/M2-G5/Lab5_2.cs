using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(12, 1, 100);
        StampaArray(array);
        int min = TrovaMinimo(array); 
            {
            Debug.Log("L'elemento minimo è " + min);
            };
        int max = TrovaMassimo(array);
            {
            Debug.Log("L'elemento massimo è " + max);
            }
       
    }
    public int[] GeneraArray( int dimensione, int min, int max)
    {
        int[] nuovoArray = new int [dimensione];

        for (int i = 0; i < dimensione; i++)
        {
            nuovoArray[i] = Random.Range(min, max + 1);
        }

        return nuovoArray;
    }
    
    public int TrovaMassimo (int[]array)
        {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
          {  if (array[i] > max)
            {
               max = array[i]; 
            }
          }
        return max;
        }  
    public int TrovaMinimo (int[]array)
        {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
         {  if (array[i] < min)
            {
               min = array[i]; 
            }
         }
        return min;
        }
    void StampaArray(int[] array) 
    {
       for(int i = 0;i < array.Length;i++) 
       {
            Debug.Log("Elemento " + i + ": " + array[i]);
       }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
