using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabellinaN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            int n = (i + 1) * 15;
            Debug.Log(n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
