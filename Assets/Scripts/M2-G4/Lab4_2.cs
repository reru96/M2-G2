using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Lab4_2 : MonoBehaviour
{
    public int[] numeri = new int[4] { 2, 4, 6, 8 };
    int somma;
    int prodotto;

    void Start()
    {
        somma = numeri[0] + numeri[1] + numeri[2] + numeri[3];
        prodotto = numeri[0] * numeri[1] * numeri[2] * numeri[3];

        int cicli = 0;

        while (somma <= 20)
        {
            Debug.Log("Somma: " + somma);
            Debug.Log("Prodotto: " + prodotto);

            cicli++;

            if (cicli == 2)
            {
                Debug.Log("Interrotto dopo 2 cicli.");
                break;
            }

            
            somma += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
