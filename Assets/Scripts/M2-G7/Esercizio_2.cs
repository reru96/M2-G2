using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Esercizio_2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        Personaggio p1 = new Personaggio();
        p1.nome = "Mario";
        p1.punteggio = 100;
        Debug.Log("Hi, it's a me, " + p1.nome + ". Con questo personaggio hai accumulato: " + p1.punteggio);
        Personaggio p2 = new Personaggio();
        p2.nome = "Luigi";
        p2.punteggio = 200;
        Debug.Log(p2.nome + " time" + ". Con questo personaggio hai accumulato: " + p2.punteggio);
        p1.IncrementaPunteggio(20);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
