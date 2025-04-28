using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_8 : MonoBehaviour
{
    public int a = 5;
    public int b = 10;
    void MaggioreTra2 ()
    {
        if (a > b) { Debug.Log("a è maggiore di b"); }
        else { Debug.Log("b è maggiore di a"); }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        MaggioreTra2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
