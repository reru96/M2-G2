using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_3_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Personaggio2 p1 = new Personaggio2();
        p1.nome = "Mario";
        p1.GetPunteggio();
        p1.SetPunteggio(100);
        Debug.Log(p1.GetPunteggio());
        p1.IsVincitore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
