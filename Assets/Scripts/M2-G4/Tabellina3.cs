using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabellina3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int num = (i + 1) * 3;
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
