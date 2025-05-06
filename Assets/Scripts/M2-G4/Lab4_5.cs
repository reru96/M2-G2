using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_5 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        int find = 10; 
        int[] numbers = new int[find];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, find + 1);
            if (numbers[i] == find)
            {
                Debug.Log("found");
            }
            else
            {
                Debug.Log("not found");
            }
        }
        Debug.Log("iterations finished");
    }

       

    // Update is called once per frame
    void Update()
    {
        
    }
}
