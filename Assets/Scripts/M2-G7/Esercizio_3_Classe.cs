using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaggio2
{
    public string nome;
    private int punteggio;

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
    public bool IsVincitore() 
    {
      if (punteggio == 100) {
            Debug.Log("il vincitore è: " + nome);  return true; }
      return false;
    }

    }


