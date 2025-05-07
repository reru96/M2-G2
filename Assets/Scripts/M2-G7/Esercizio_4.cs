using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Esercizio_4 : MonoBehaviour
{
    public int danno;
    // Start is called before the first frame update
    void Start()
    {
        Personaggio p1 = new Personaggio();
        Enemy n1 = new Enemy();
        p1.nome = "Mario";
        n1.nome = "Goomba";
        n1.salute = 100;
        n1.livello = 10;
        Debug.Log("Appare " + n1.nome + " di livello " + n1.livello);
        Debug.Log(p1.nome + " attacca " + n1.nome);
        n1.SubisciDanno(danno);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
