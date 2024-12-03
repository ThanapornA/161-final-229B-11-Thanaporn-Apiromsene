using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpell : Spell
{
    private void Start()
    {
        Init("Something Spell" , 6);
        newTypeOfCast();
    }

    public void newTypeOfCast()
    {
        Debug.Log("Casting a new spell!");
    }
}
