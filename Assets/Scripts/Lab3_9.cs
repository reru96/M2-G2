using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_9 : MonoBehaviour
{
    public int a = 5;
    public int b = 10;
    void MinoreTra2()
    {
        if (a < b) { Debug.Log("a è minore di b"); }
        else { Debug.Log("b è minore di a"); }

    }
    // Start is called before the first frame update
    void Start()
    {
        MinoreTra2 ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
