using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_3 : MonoBehaviour
{
    public int numero = 30;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= numero; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
