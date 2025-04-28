using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_5 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        int find = Random.Range(1, 51); 
        int x = 10; 
        int[] numbers = new int[x];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Random.value < 0.2f) 
            {
                numbers[i] = find;
            }
            else
            {
                numbers[i] = Random.Range(1, 51);
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
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
