using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (e % 2 == 0)
        { Debug.Log("è pari"); }
        else { Debug.Log("è dispari"); }
        ;
        if (e > 10)
        { Debug.Log("è maggiore"); }
        else { Debug.Log("è minore"); }
    }
    public int e = 7;
    // Update is called once per frame
    void Update()
    {
        
    }
}
