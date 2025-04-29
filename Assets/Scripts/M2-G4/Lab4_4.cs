using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lab4_4 : MonoBehaviour
{
    public int start = 5;
    public int amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = start + 3;
        for (int i = start; i <= amount; i++) 
        {  
            Debug.Log(i);
     
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
