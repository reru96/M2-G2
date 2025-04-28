using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num = 10;
    public int index = 7;
    void Start()
    {
        while (index >= 0) {

            Debug.Log("Il prezzo della spesa giornaliera sale a: " + num + " " + "euro"); 
            num++;

            Debug.Log("Il valore di acquisto scende a: " + index + " " + "euro");
                index--;
        }
        Debug.Log("crisi economica");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
