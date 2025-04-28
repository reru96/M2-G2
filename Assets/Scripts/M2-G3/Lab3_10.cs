using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float time = 0f;
    // Update is called once per frame
    void Update()
    {
     time += Time.deltaTime;
     if (time <= 30f) { Debug.Log("sono trascorsi meno di 30 secondi"); }
     else if (time >= 30f && time <=31f) { Debug.Log("sono trascorsi più di 30 secondi"); }
     else if (time <= 45f) { Debug.Log("sono trascorsi meno di 45 secondi"); }
     else if (time >= 45f) { Debug.Log("sono trascorsi più di 45 secondi"); }
    }
}
