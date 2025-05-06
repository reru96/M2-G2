using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum Damage_Type 
    { SLASHING,
      PIERCING,
      BLUDGEONING,
      MAGIC,
      FORCE
    }
    public Damage_Type attackType = Damage_Type.SLASHING;
    public Damage_Type resistance = Damage_Type.SLASHING;
    public Damage_Type weakness = Damage_Type.SLASHING;
    public int baseDamage = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance && attackType != weakness)
        {
            baseDamage = baseDamage / 2;
            Debug.Log("non è molto efficace: " + baseDamage + " danni");
        }
        else if (attackType == weakness && attackType != resistance)
        {
            baseDamage = baseDamage * 2;
            Debug.Log("è superefficace: " + baseDamage + " danni");
        }
        else Debug.Log(baseDamage + " danni");
    }
            // Update is called once per frame
            void Update()
            {

            }
}
