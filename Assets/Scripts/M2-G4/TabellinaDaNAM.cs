using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabellinaDaNAM : MonoBehaviour
{
    public int n;
    public int m;
    // Start is called before the first frame update
    void Start()
    {
        m = n + 1;
        Debug.Log("Tabellina del " + n);
        for (int i = 0; i < 10; i++)
        {
            
            int num = (i + 1) * n;
            Debug.Log(num);

        }
        Debug.Log("Tabellina del " + m);
        for (int i = 0; i < 10; i++)
        {

            int num = (i + 1) * m;
            Debug.Log(num);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
