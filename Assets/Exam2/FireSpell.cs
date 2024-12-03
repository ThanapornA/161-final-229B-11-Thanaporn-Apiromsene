using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    void Start()
    {
        Init("Fireball Spell" , 5);
        Cast("slimeA");
    }
}
