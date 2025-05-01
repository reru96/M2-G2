using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabellineDa1A10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
        for (int n = 1; n <= 10; n++)
        { Debug.Log("Tabellina del:" + n);
            for (int i = 1; i < 10; i++)
            {
                int m = (i + 1) * n;
                Debug.Log(m); 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
