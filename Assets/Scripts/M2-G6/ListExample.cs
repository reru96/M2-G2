using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax = 15;

    void Start()
    {
        List<int> numeri = new List<int>();

        for (int i = 0; i <= numeroMax; i++)
        {
            int posizione = i % 3;

            if (posizione == 0)
            {
                numeri.Insert(0, i);
            }
            else if (posizione == 1)
            {
                numeri.Add(i);
            }
            else
            {
                int posizioneMeta = numeri.Count / 2;
                numeri.Insert(posizioneMeta, i);
            }
            string risultato = string.Join(", ", numeri);
            Debug.Log("Contenuto lista: " + risultato);
        }

    }


    void Update()
    {

    }
}
