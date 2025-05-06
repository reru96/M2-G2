using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Esercizio_3 : MonoBehaviour
{
    [SerializeField]
    public string s1 = "(Aragorn; left; angry) Che siate attento, non è un gingillo quello che portate!";
    public string s2 = "(Gandalf; right) Uno stregone non è mai in ritardo, arriva precisamente quando intende farlo.";

    void Start()
    {
        DivideString(s1);
        DivideString(s2);
    }

    void DivideString(string input)
    {
        if (!input.StartsWith("(") || !input.Contains(")"))
        {
            Debug.LogError(input);
            return;
        }

        int chiusura = input.IndexOf(')');
        string dentroParentesi = input.Substring(1, chiusura - 1);
        string frase = input.Substring(chiusura + 1).Trim();

        string[] parti = dentroParentesi.Split(new char[] { ';', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

        foreach (string parte in parti)
        {
            Debug.Log(parte.Trim());
        }

        Debug.Log(frase);
    }


    void Update()
   {

   }
}

