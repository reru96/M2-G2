using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_11 : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 10)]
    public int voto = 9;

    void Start()
    {
        if (voto >= 10)
            Debug.Log("A+");
        else if (voto >= 9) Debug.Log("A");
        else if (voto >=7.8) Debug.Log("B");
        else if (voto >= 6) Debug.Log("C");
        else if (voto >= 5) Debug.Log("E");
        else if (voto <= 0.4) Debug.Log("F");
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
