using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (e % 2 == 0)
        { Debug.Log("� pari"); }
        else { Debug.Log("� dispari"); }
        ;
        if (e > 10)
        { Debug.Log("� maggiore"); }
        else { Debug.Log("� minore"); }
    }
    public int e = 7;
    // Update is called once per frame
    void Update()
    {
        
    }
}
