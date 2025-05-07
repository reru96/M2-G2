using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Personaggio
{
    public string nome;
    public int punteggio;

    public void IncrementaPunteggio(int nuovopunteggio)
    {
        punteggio += nuovopunteggio;
        Debug.Log("Nuovo punteggio: " + punteggio);

    }

    public int GetPunteggio()
    {
        if (punteggio < 0)
        {
            punteggio = 0;

        }
        return punteggio;
    }

    public void SetPunteggio(int nuovopunteggio)
    {

        punteggio = nuovopunteggio;
        Debug.Log("il nuovo punteggio è: " + nuovopunteggio);
    }


}

public class Enemy
{
    public string nome;
    public int livello;
    public float salute;

    public float SubisciDanno(float danno)
    {
        salute -= danno;
        if (salute < 0)
        {
            salute = 0;
            Debug.Log(nome + " ha subito " + danno + " danni, è sceso a " + salute + " hp.");
            Debug.Log(nome + " è stato sconfitto.");
            return salute;
        }
        Debug.Log(nome + " ha subito " + danno + " danni, è sceso a " + salute + " hp.");
        return salute;
    }
}

