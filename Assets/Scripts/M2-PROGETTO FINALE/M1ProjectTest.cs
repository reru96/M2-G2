using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1ProjectTest : MonoBehaviour
{
    public Hero hero_a = new Hero
        (
        "Dai", // NAME
        100,  // HP
        new Stats(10, 10, 10, 10, 10, 10, 10), // STATS (ATK, DEF, RES, SPD, CRT, AIM, EVA)
        ELEMENT.ICE, // RESISTENCE 
        ELEMENT.FIRE,// WEAKNESS 
        new Weapon(
            "Master Sword",
            Weapon.DAMAGE_TYPE.PHYSICAL,
            ELEMENT.FIRE,
            new Stats(10, 10, 10, 10, 10, 10, 10)
            )
        );
    public Hero hero_b = new Hero
        ("Hyunkel", 
        100, 
        new Stats(10, 10, 10, 10, 10, 10, 10), 
        ELEMENT.FIRE, 
        ELEMENT.ICE, 
        new Weapon(
            "Lance of Karakuri", 
            Weapon.DAMAGE_TYPE.MAGICAL, 
            ELEMENT.FIRE, 
            new Stats(10, 10, 10, 10, 10, 10, 10)
            )
        );

    private bool duelDone = false;

    public void Start()
    {

    }

    public void Update()
    {
        if (!duelDone)
        {
            duel(hero_a, hero_b);
            duelDone = true;
        }
    }

    public void duel(Hero hero_a, Hero hero_b)
    {
        int speed1 = hero_a.baseStats_.spd + hero_a.weapon_.BonusStats.spd;
        int speed2 = hero_b.baseStats_.spd + hero_b.weapon_.BonusStats.spd;

        while (hero_a.IsAlive(hero_a.hp_) && hero_b.IsAlive(hero_b.hp_))
        {
          
            if (speed1 >= speed2)
            {
                Attack(hero_a, hero_b);
                if (hero_b.IsAlive(hero_b.hp_))
                    Attack(hero_b, hero_a);
            }
            else
            {
                Attack(hero_b, hero_a);
                if (hero_a.IsAlive(hero_a.hp_))
                    Attack(hero_a, hero_b);
            }
        }

        Debug.Log("Duel ended");
        if (!hero_a.IsAlive(hero_a.hp_))
            Debug.Log(hero_a.name_ + " is defeated. " + hero_b.name_ + " wins.");
        else if (!hero_b.IsAlive(hero_b.hp_))
            Debug.Log(hero_b.name_ + " is defeated. " + hero_a.name_ + " wins.");
    }

    private void Attack(Hero attacker, Hero defender)
    {
        Debug.Log(attacker.name_ + " attacks and " + defender.name_ + " defends.");

        if (GameFormulas.HasHit(attacker.baseStats_, defender.baseStats_))
        {
            int damage = GameFormulas.CalculateDamage(attacker, defender);
            defender.TakeDamage(damage);
            Debug.Log(attacker.name_ + "'s hit connects! " + defender.name_ + " takes " + damage + " damage. HP left: " + defender.hp_);
        }
        else
        {
            Debug.Log(attacker.name_ + "'s attack missed!");
        }
    }
}
