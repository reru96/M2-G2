using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public struct Stats
{

    public int atk;
    public int def;
    public int res;
    public int spd;
    public int crt;
    public int aim;
    public int eva;

    public Stats(int atk, int def, int res, int speed, int crt, int aim, int eva)
    {
        this.atk = atk;
        this.def = def;
        this.res = res;
        this.spd = speed;
        this.crt = crt;
        this.aim = aim;
        this.eva = eva;
    }

    public static Stats Sum(Stats a, Stats b)
    {
        Stats result;
        result.atk = a.atk + b.atk;
        result.def = a.def + b.def;
        result.res = a.res + b.res;
        result.spd = a.spd + b.spd;
        result.crt = a.crt + b.crt;
        result.aim = a.aim + b.aim;
        result.eva = a.eva + b.eva;
        return result;
    }
}

public enum ELEMENT
{
    NONE, FIRE, ICE, ELECTRICS
}

[Serializable]
public class Weapon
{
    public enum DAMAGE_TYPE
    {
        PHYSICAL, MAGICAL
    }

    [SerializeField]
    private string name;
    [SerializeField]
    private DAMAGE_TYPE type;
    [SerializeField]
    private ELEMENT elem;
    [SerializeField]
    private Stats bonusStats;

    public Weapon(string name, DAMAGE_TYPE type, ELEMENT element, Stats bonus)
    {
        this.name = name;
        this.type = type;
        this.elem = element;
        this.bonusStats = bonus;
    }
    public string Name
    {
        get => name;
        set => name = value;
    }

    public DAMAGE_TYPE Type
    {
        get => type;
        set => type = value;
    }

    public ELEMENT Elem
    {
        get => elem;
        set => elem = value;
    }

    public Stats BonusStats
    {
        get => bonusStats;
        set => bonusStats = value;
    }

}

[Serializable]
public class Hero
{
    [SerializeField]
    private string name;
    [SerializeField]
    private int hp;
    [SerializeField]
    private Stats baseStats;
    [SerializeField]
    private ELEMENT resistence;
    [SerializeField]
    private ELEMENT weakness;
    [SerializeField]
    private Weapon weapon;

    public Hero(string name, int hp, Stats baseStats, ELEMENT resistence,
        ELEMENT weakness, Weapon weapon)
    {

        this.name = name;
        this.hp = hp;
        this.baseStats = baseStats;
        this.resistence = resistence;
        this.weakness = weakness;
        this.weapon = weapon;
    }

    public string name_
    {
        get => name;
        set => name = value;
    }
    public int hp_
    {
        get => hp;
        set => hp = value;
    }

    public Stats baseStats_
    {
        get => baseStats;
        set => baseStats = value;
    }

    public ELEMENT resistence_
    {
        get => resistence;
        set => resistence = value;
    }

    public ELEMENT weakness_
    {
        get => weakness;
        set => weakness = value;
    }
    public Weapon weapon_
    {
        get => weapon;
        set => weapon = value;
    }
    public int AddHp(int amount)
    {
        hp_ = hp + amount;
        return hp_;

    }

    public int TakeDamage(int damage)
    {
        return AddHp(-damage);
    }

    public bool IsAlive(int hp)
    {
        if (hp == 0)
        { return false; }
        else return true;
    }

}

public static class GameFormulas
{
    public static bool HasElementAdvantage(ELEMENT attackElement, Hero defender)
    {

        if (attackElement == defender.weakness_)
        { return true; }
        else
            return false;
    }

    public static bool ElementDisadvantage(ELEMENT attackElement, Hero defender)
    {
        if (attackElement == defender.resistence_) { return true; }
        else return false;
    }

    public static float EvaluateElementalModifier(ELEMENT attackElement, Hero defender)
    {
        if (HasElementAdvantage(attackElement, defender) && !ElementDisadvantage(attackElement, defender))
            return 1.5f;
        else if (ElementDisadvantage(attackElement, defender) && !HasElementAdvantage(attackElement, defender))
            return 0.5f;
        else
            return 1f;
    }

    public static bool HasHit(Stats attacker, Stats defender)
    {
        int hitChance = Math.Clamp(attacker.aim - defender.eva, 0, 100);
        int chance = Random.Range(0, 99);
        if (chance < hitChance)
        { 
            return true; 
        }
        else

            Debug.Log("MISS");
            return false;
    
    }

    public static bool IsCrit(Stats attacker)
    {
        int critValue = attacker.crt;
        int critical = Random.Range(0, 99);
        if (critical < critValue)
        { 
            Debug.Log("CRIT"); 
            return true; 
        }
        else
            return false;
    }

    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        Stats totalAtkStats = Stats.Sum(attacker.baseStats_, attacker.weapon_.BonusStats);
        int defense = defender.baseStats_.def;
        int baseDamage = Mathf.Max(totalAtkStats.atk - defense, 1);
        float elementalModifier = EvaluateElementalModifier(attacker.weapon_.Elem, defender);
        float critModifier = IsCrit(totalAtkStats) ? 2f : 1f;
        float finalDamage = baseDamage * elementalModifier * critModifier;

        return Mathf.Max(Mathf.RoundToInt(finalDamage), 0);
    }
}
