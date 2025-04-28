using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_6 : MonoBehaviour
{
    public int partenza = 20;

    private void Stampa2Successivi()
    {   Debug.Log(partenza);
        Debug.Log(partenza + 1);
        Debug.Log(partenza + 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        Stampa2Successivi();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
