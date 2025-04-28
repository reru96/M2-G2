using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a + b + c + d);
        Debug.Log(a * b * c * d);
        Debug.Log((a + b + c + d) / 4);
    }

    public int a = 15;
    public int b = 10;
    public int c = 5;
    public int d = 3;
    // Update is called once per frame
    void Update()
    {
        
    }
}
