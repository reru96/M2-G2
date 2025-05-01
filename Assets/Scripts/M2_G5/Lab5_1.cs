using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lab5_1 : MonoBehaviour
{  
    public int number;
    public int multiPle;
    public int baSe;

    void isEven( int number)
    {
        if (number % 2 == 0) 
            Debug.Log(true + ": il numero " + number + " è pari ");
        else 
            Debug.Log(false + ": il numero " + number + " è dispari ");
    }

    void isMultiple(int baSe, int multiPle)
        { if (multiPle % baSe == 0)
            Debug.Log(true + ": il numero " + multiPle + " è multiplo di " + baSe);

        else
            Debug.Log(false + ": il numero " + multiPle + " non è multiplo di " + baSe);
 
        }
    // Start is called before the first frame update
    void Start()
    {
    isEven(10);
    isMultiple(11, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
