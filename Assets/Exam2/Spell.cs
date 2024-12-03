using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string SpellName;
    public string targetName;
    public int castDamage;
    public int PowerLvl;

    private void Start()
    {
        Debug.Log("Spell-Casting simulation Started !");
    }

    public void Init(string newName , int powerLvl)
    {
        SpellName = newName;
        PowerLvl = powerLvl;
    }
    public virtual void Cast()
    {
        Debug.Log("Casting a generic spell!");
    }

    public void Cast( string newstring )
    {
        targetName = newstring;
        Debug.Log($"Casting a {SpellName} ! Burn them all!");
        Debug.Log($"Casting a spell on : {targetName} ");
        Debug.Log($"Casting a spell on {targetName} with power lvl : {PowerLvl}");
    }


    public void Cast( string newstring , int newValue )
    {
        targetName = newstring;
        castDamage = newValue;

        Debug.Log($"Casting a {SpellName} ! Freeze them all!");
        Debug.Log($"Casting a spell on : {targetName} ");
        Debug.Log($"Casting a spell on {targetName} with power lvl : {castDamage}");
    }
}
